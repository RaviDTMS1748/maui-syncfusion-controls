using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using syncfusioncontrolinmaui.Models;
using syncfusioncontrolinmaui.Navigation;
using syncfusioncontrolinmaui.Services;

namespace syncfusioncontrolinmaui.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		private readonly IUserService _userService;
		private readonly INavigationService _navigationService;
		public MainViewModel(IUserService userService, INavigationService navigationService)
		{
			_userService = userService;
			_navigationService = navigationService;
			//Users = _userService.GetUsers();
			GetUsers();
			ShowIcon = true;
		}

		[ObservableProperty]
		private bool showIcon;

		[ObservableProperty]
		private ObservableCollection<User> users;

		[ObservableProperty]
		private User selectedUser;

		partial void OnSelectedUserChanged(User value)
		{
			if (value != null)
			{
				LastName = value.LastName;
				Address = value.Address;
				Pincode = value.Pincode;
				PhoneNumber = value.PhoneNumber;
			}
		}

		[ObservableProperty] private string lastName;
		[ObservableProperty] private string address;
		[ObservableProperty] private string pincode;
		[ObservableProperty] private string phoneNumber;

		public void GetUsers()
		{
			Users = _userService.GetUsers();
		}

		[RelayCommand]
		private void AddUser()
		{
			var newUser = new User { Name = "New", LastName = "User", Address = "New Address", Pincode = "000000", PhoneNumber = "0000000000" };


			var updatedList = new ObservableCollection<User>(Users) { newUser };
			Users = updatedList;

			//Users.Add(newUser);
		//	GetUsers();
			//OnPropertyChanged(nameof(Users));
		}

		[RelayCommand]
		private void RemoveUser()
		{
			if (SelectedUser != null)
				Users.Remove(SelectedUser);
		}


		[RelayCommand]
		private async Task GoToScalesPage()
		{

			await _navigationService.NavigateToAsync<NavigationDrawer>();
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
