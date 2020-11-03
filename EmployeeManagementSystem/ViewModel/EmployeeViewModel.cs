using Employee.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModel
{
	public class EmployeeViewModel 
	{
		public List<EmployeeModel> Employees { get; set; }

		public Meta PaginationData { get; set; }

		public int page { get; set; }

		public string ErrorInfo { get; set; }
	}

	public class EmployeeModel
	{
		public int Id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string gender { get; set; }
		public string status { get; set; }

	}
}
