using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using syncfusioncontrolinmaui.Navigation;
using syncfusioncontrolinmaui.Services;
using syncfusioncontrolinmaui.ViewModels;

namespace syncfusioncontrolinmaui
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JFaF5cXGRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWH9eeHRcQ2FdUkxwV0pWYEA=");
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
					fonts.AddFont("MauiMaterialAssets.ttf", "MaterialAssets");
				})
				.ConfigureSyncfusionCore();


			builder.Services.AddSingleton<App>();
			builder.Services.AddSingleton<IUserService, UserService>();
			builder.Services.AddSingleton<INavigationService, NavigationService>();


			var viewmodels = new Dictionary<Type, Type>
			{
				{typeof(MainViewModel),typeof(MainPage) },
				{typeof(ScalesViewModel),typeof(ScalesPage) },
				{typeof(DockLayoutViewModel),typeof(DockLayout) },
				{typeof(NavigationDrawerViewModel),typeof(NavigationDrawer) },
			};
			//foreach (var model in viewmodels)
			//{
			//	builder.Services.AddTransient(model.Key);
			//	Routing.RegisterRoute(model.Value.Name, model.Value);
			//	builder.Services.AddTransient(model.Value, serviceProvide =>
			//	{
			//		var page = Activator.CreateInstance(model.Value) as Page;
			//		var viewModel = serviceProvide.GetRequiredService(model.Key);
			//		if (page != null)
			//		{
			//			page.BindingContext = viewModel;
			//		}
			//		return page;
			//	});
			//}

			var pageFactory = new Dictionary<Type, Func<Page>>();


			foreach (var model in viewmodels)
			{
				builder.Services.AddTransient(model.Key);
				Routing.RegisterRoute(model.Value.Name, model.Value);

				pageFactory[model.Value] = () =>
				{
					var page = Activator.CreateInstance(model.Value) as Page;
					var viewModel = builder.Services.BuildServiceProvider().GetRequiredService(model.Key);
					if (page != null)
					{
						page.BindingContext = viewModel;
					}
					return page;
				};

				builder.Services.AddTransient(model.Value, serviceProvider =>
				{
					var page = Activator.CreateInstance(model.Value) as Page;
					var viewModel = serviceProvider.GetRequiredService(model.Key);
					if (page != null)
					{
						page.BindingContext = viewModel;
					}
					return page;
				});
			}

			builder.Services.AddSingleton<INavigationService>(sp =>
			{
				return new NavigationService(pageFactory);
			});





#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
