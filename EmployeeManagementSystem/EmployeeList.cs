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
	public partial class EmployeeList : UserControl
	{
		public EmployeeList(EmployeeViewModel employeeViewModel)
		{
			InitializeComponent();
			this.dataGridView1.DataSource = employeeViewModel;
				
		}
	}
}
