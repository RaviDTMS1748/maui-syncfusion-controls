using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusioncontrolinmaui.Navigation
{

	public interface INavigationService
	{
			Task NavigateToAsync(Page page);
			Task NavigateToAsync<TPage>() where TPage : Page;
			Task NavigateToAsync<TPage>(object parameter) where TPage : Page;
			Task GoBackAsync();
		

	}

}
