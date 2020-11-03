using Employee.Core;
using EmployeeManagementSystem.ViewModel;
using EmployeeOperations.API;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
	public class SearchHandler : ICommandHandler<SearchCommand>
	{
		public IEmployeeService employeeService { get; }
		public SearchContext searchContext { get; }
		public EmployeeViewModel employeeViewModel { set; get; }

		public SearchHandler(IEmployeeService employeeService,
			SearchContext searchContext,
			EmployeeViewModel employeeViewModel
			)
		{
			this.employeeService = employeeService;
			this.searchContext = searchContext;
			this.employeeViewModel = employeeViewModel;
		}
		public async Task HandleAsync(SearchCommand command, string source)
		{
				var response =	employeeService.GetAllEmployee();
			 await Task.Run(()=> CreateViewModel(response));
		}
		public void CreateViewModel(Task<Response<RootList>> response)
		{
			var employeeList = new List<EmployeeModel>();

			List<EmployeeData> employeesList = response.Result.Data.data;
			foreach (var item in employeesList)
			{
				EmployeeModel emp = new EmployeeModel();
				emp.Id = item.id;
				emp.email = item.name;
				emp.gender = item.gender;
				emp.name = item.name;
				emp.status = item.status;
				employeeList.Add(emp);
			}
			employeeViewModel.Employees = employeeList;
			employeeViewModel.PaginationData = response.Result.Data.meta;
		}

	}

	public class SearchCommand : ICommand
	{
		public SearchCommand()
		{

		}
	}
}
