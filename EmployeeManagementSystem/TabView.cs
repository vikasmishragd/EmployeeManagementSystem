using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem
{
	public partial class TabView : UserControl,IEmployeeView
	{
		public TabView()
		{
			InitializeComponent();
		}

		public void SetDataSource(EmployeeViewModel employeeViewModel)
		{
			throw new NotImplementedException();
		}

		
	}
}
