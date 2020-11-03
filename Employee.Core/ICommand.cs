using System.Threading.Tasks;

namespace Employee.Core
{
	public interface ICommand
    {
    }

    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command, string source);
    }

    public interface ICommandDispatcher
    {
        Task DispatchAsync<T>(T command, string source) where T : ICommand;
    }
}
