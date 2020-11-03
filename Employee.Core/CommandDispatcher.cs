using Autofac;
using System;
using System.Threading.Tasks;

namespace Employee.Core
{
	public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext context;

        public CommandDispatcher(IComponentContext context) => this.context = context;

        public async Task DispatchAsync<T>(T command, string source) where T : ICommand
        {
            if (command == null) throw new ArgumentNullException(nameof(command));

            var handler = context.Resolve<ICommandHandler<T>>();

            await handler.HandleAsync(command, source);

            return;
        }
    }
}
