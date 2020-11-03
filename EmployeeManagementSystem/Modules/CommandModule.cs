using Autofac;
using Employee.Core;
using Employee.Opertions;
using EmployeeManagementSystem.ViewModel;
using EmployeeOperations.API;
using System.Linq;

namespace EmployeeManagementSystem
{
    public class CommandModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(Program).Assembly;

            builder
                .RegisterType<CommandDispatcher>()
                .As<ICommandDispatcher>()
                .SingleInstance();

            builder
                .RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>));

            builder
                .RegisterType<CommandInvoker>()
                .As<ICommandInvoker>()
                .SingleInstance();

            builder.RegisterAssemblyTypes(assembly)
                    .Where(t => t.Name.EndsWith("Command"))
                    .Named<ICommand>(t => t.Name);

            builder
               .RegisterType<EmployeeService>()
               .As<IEmployeeService>()
               .SingleInstance();

            builder
                .RegisterType<SearchContext>()
                .SingleInstance();
            builder
               .RegisterType<EmpAddContext>()
               .SingleInstance();
            builder
            .RegisterType<EmployeeViewModel>()
            .SingleInstance();

            builder
                .RegisterType<EmployeeRepository>()
                .As<IEmployeeRepository>()
                .SingleInstance();

        }
    }
}
