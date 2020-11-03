using Employee.Core;
using log4net;
using System.Threading.Tasks;


namespace EmployeeOperations.API
{
	public class EmployeeService : IEmployeeService
	{
		public EmployeeService(SearchContext searchContext,EmpAddContext empAddContext,
			ILog log,IEmployeeRepository employeeRepository)
		{
			this.searchContext = searchContext;
			this.empAddContext = empAddContext;
			Log = log;
			this.employeeRepository = employeeRepository;
		}

		private SearchContext searchContext { get; }
		private EmpAddContext empAddContext { get; }
		public ILog Log { get; }
		public IEmployeeRepository employeeRepository { get; }

		public async Task<Response<RootList>> GetAllEmployee()
		{
			var res =	await employeeRepository.GetAllEmployees<RootList>(searchContext);
			return new Response<RootList> { Data = res };
		}


		public async Task<Response<string>> AddEmployee()
		{
			var response = await employeeRepository.Post( empAddContext);
			return new Response<string> { Data =response};
		}

		public async Task<Response<Root>> GetEmployee(string url)
		{
			var res = await employeeRepository.GetEmployee<Root>(url);
			return new Response<Root> { Data = res };
		}
	}
}
