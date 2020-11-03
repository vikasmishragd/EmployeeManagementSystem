using Employee.Core;
using System.Threading.Tasks;

namespace EmployeeOperations.API
{
	public interface IEmployeeService
	{
		Task<Response<RootList>> GetAllEmployee();
		Task<Response<Root>> GetEmployee(string url);
		Task<Response<string>> AddEmployee();
	}
}
