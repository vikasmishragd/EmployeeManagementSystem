using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
	static class Program
	{
		private static IContainer Container { get; set; }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var builder = new ContainerBuilder();
			builder.RegisterModule(new CommandModule());
			builder.RegisterModule(new EmployeeControl());
			Container = builder.Build();
			var form = Container.Resolve<EmployeeManagementSystem>();

			Application.Run(form);
		}
	}
}
