using System.Threading.Tasks;

namespace Employee.Core
{
	public interface IEmployeeRepository
	{
		Task<T> GetAllEmployees<T>(SearchContext searchContext);
		Task<T> GetEmployee<T>(string url);

		Task<string> Post<T>(T contentValue);
	}
}
