using Employee.Core;
using EmployeeManagementSystem.ViewModel;
using EmployeeOperations.API;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
	public class EmpAddHandler : ICommandHandler<EmpAddCommand>
	{
		public EmpAddHandler(IEmployeeService  employeeService, EmpAddContext empAddContext, EmployeeViewModel employeeViewModel)
		{
			this.employeeService = employeeService;
			this.empAddContext = empAddContext;
			this.employeeViewModel = employeeViewModel;
		}

		public IEmployeeService employeeService { get; }
		public EmpAddContext empAddContext { get; }
		public EmployeeViewModel employeeViewModel { get; set; }

		public async Task HandleAsync(EmpAddCommand command, string source)
		{
			var response =await employeeService.AddEmployee();
			if(!string.IsNullOrEmpty(response.Data))
			{
				var result = employeeService.GetEmployee(response.Data);
				await Task.Run(() => CreateViewModel(result));
			}
			else
			{
				employeeViewModel.ErrorInfo = "Employee not saved, Please check the supplied data";
			}
		}
		public void CreateViewModel(Task<Response<Root>> response)
		{
			var employeeList = new List<EmployeeModel>();

			EmployeeData employee = response.Result.Data.data;

			EmployeeModel emp = new EmployeeModel();
			emp.Id = employee.id;
			emp.email = employee.email;
			emp.gender = employee.gender;
			emp.name = employee.name;
			emp.status = employee.status;
			employeeList.Add(emp);

			employeeViewModel.Employees = employeeList;
			employeeViewModel.PaginationData = null;

		}
	}

	public class EmpAddCommand : ICommand
	{
		public EmpAddCommand()
		{

		}
	}
}
