using Autofac;
using Employee.Core;
using log4net;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
	public interface ICommandInvoker
    {
        Task InvokeAsync(string name, string source);
    }

    public class CommandInvoker : ICommandInvoker
    {
        private readonly ICommandDispatcher dispatcher;
        private readonly IComponentContext context;
        private readonly ILog logger;

        public CommandInvoker(ICommandDispatcher dispatcher, IComponentContext context, ILog logger)
        {
            this.dispatcher = dispatcher;
            this.context = context;
            this.logger = logger;
        }

        public async Task InvokeAsync(string name, string source)
        {
            if (string.IsNullOrEmpty(name))
                return;

            logger.InfoFormat("Invoking command - {0}", name);

            dynamic command = context.ResolveNamed<ICommand>(name);

            await dispatcher.DispatchAsync(command, source);
        }
    }
}
