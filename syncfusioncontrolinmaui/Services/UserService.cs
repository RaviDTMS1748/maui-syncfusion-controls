using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using syncfusioncontrolinmaui.Models;

namespace syncfusioncontrolinmaui.Services
{

	public class UserService : IUserService
	{
		public ObservableCollection<User> GetUsers() => new()
		{
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
			new User { Name = "Ravi", LastName = "Pampana", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "1234567890" },
			new User { Name = "Satya", LastName = "Revu", Address = "Delhi", Pincode = "110001", PhoneNumber = "8989898989" },
			new User { Name = "Chellam", LastName = "Mandala", Address = "Hyderabad", Pincode = "500001", PhoneNumber = "9999999999" },
			new User { Name = "Anil", LastName = "Kumar", Address = "Delhi", Pincode = "110001", PhoneNumber = "9876543210" },
		};
	}

}
