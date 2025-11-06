using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using syncfusioncontrolinmaui.Navigation;

namespace syncfusioncontrolinmaui
{
	public partial class ScalesViewModel : ObservableObject
	{
		private readonly INavigationService _navigationService;
		public ScalesViewModel(INavigationService navigationService)
		{
			Name = "Ravi";
			_navigationService = navigationService;
		}
		[ObservableProperty]
		private string name;
		[RelayCommand]
		private async Task GoToDockLayout()
		{

			await _navigationService.NavigateToAsync<DockLayout>();
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
