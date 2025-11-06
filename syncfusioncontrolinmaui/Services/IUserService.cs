using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using syncfusioncontrolinmaui.Models;

namespace syncfusioncontrolinmaui.Services
{

	public interface IUserService
	{
		ObservableCollection<User> GetUsers();
	}

}
