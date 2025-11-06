using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace syncfusioncontrolinmaui.Navigation
{
	public class NavigationService : INavigationService
	{
		private readonly Dictionary<Type, Func<Page>> _pageFactories;

		public NavigationService(Dictionary<Type, Func<Page>> pageFactories)
		{
			_pageFactories = pageFactories;
		}

		public Task NavigateToAsync(Page page)
		{
			return Application.Current.MainPage.Navigation.PushAsync(page);
		}

		public Task NavigateToAsync<TPage>() where TPage : Page
		{
			var page = _pageFactories[typeof(TPage)].Invoke();
			return NavigateToAsync(page);
		}

		public Task NavigateToAsync<TPage>(object parameter) where TPage : Page
		{
			var page = _pageFactories[typeof(TPage)].Invoke();

			if (page.BindingContext is IInitializeWithParameter vm)
			{
				vm.Initialize(parameter);
			}

			return NavigateToAsync(page);
		}

		public Task GoBackAsync()
		{
			return Application.Current.MainPage.Navigation.PopAsync();
		}

		
	}
	public interface IInitializeWithParameter
	{
		void Initialize(object parameter);
	}
}
