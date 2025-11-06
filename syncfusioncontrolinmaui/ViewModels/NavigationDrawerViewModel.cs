using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using syncfusioncontrolinmaui.Navigation;

namespace syncfusioncontrolinmaui.ViewModels
{
	public partial class NavigationDrawerViewModel : ObservableObject
	{
		private readonly INavigationService _navigationService;
		public NavigationDrawerViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		[ObservableProperty]
		private string headerText = "Home";

		[ObservableProperty]
		private string contentText = "Content View";

		public ObservableCollection<string> MenuItems { get; } = new()
		{
			"Home", "Profile", "Inbox", "Outbox", "Sent", "Draft"
		};

		public Action? ToggleDrawerAction { get; set; }

		[RelayCommand]
		private void ToggleDrawer()
		{
			ToggleDrawerAction?.Invoke();
		}

		public void OnMenuItemSelected(string selectedItem)
		{
			HeaderText = selectedItem;
			ContentText = $"{selectedItem} Content";
		}
	}
}
