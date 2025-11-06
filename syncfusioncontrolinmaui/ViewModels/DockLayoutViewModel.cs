using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using syncfusioncontrolinmaui.Navigation;

namespace syncfusioncontrolinmaui.ViewModels
{
	public partial class DockLayoutViewModel : ObservableObject
	{
		private readonly INavigationService _navigationservice;
		public DockLayoutViewModel(INavigationService navigationservice)
		{
			_navigationservice = navigationservice;
		}
		[RelayCommand]
		private async Task GoToMainPage()
		{

			await _navigationservice.NavigateToAsync<MainPage>();
			//await Shell.Current.GoToAsync("DockLayout");

			//var nav = Application.Current?.MainPage?.Navigation;
			//if (nav != null)
			//{
			//	var page = App.ServiceProvider.GetService<ScalesPage>();
			//	if (page != null)
			//		await nav.PushAsync(page);
			//}
		}
	}
}
