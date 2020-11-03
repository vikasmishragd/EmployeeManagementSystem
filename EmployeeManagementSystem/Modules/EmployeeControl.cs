using Autofac;
using log4net;

namespace EmployeeManagementSystem
{
	public class EmployeeControl : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder
				.RegisterType<EmployeeManagementSystem>()
				.AsSelf()
				.SingleInstance();

			builder
			 .Register(ctx => Logging.Logger)
			 .As<ILog>();


		}
	}

}
