using Employee.Core;
using EmployeeManagementSystem.Extentions;
using EmployeeManagementSystem.ViewModel;
using log4net;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
	public partial class EmployeeManagementSystem : Form
	{
		private readonly ICommandInvoker commandInvoker;
		private readonly SearchContext searchContext;
		private readonly EmpAddContext empAddContext;
		private readonly EmployeeViewModel employeeViewModel;

		public ILog Logger { get; }

		public int Currentpage = 0;
		public EmployeeManagementSystem(ICommandInvoker commandInvoker,
			ILog logger,
			SearchContext searchContext,
			EmpAddContext empAddContext,
			EmployeeViewModel employeeViewModel)
		{
			InitializeComponent();
			btnSearch.Click += BtnSearch_Click;
			//btnSubmit.Click += btnSubmit_Click;
			this.commandInvoker = commandInvoker;
			Logger = logger;
			this.searchContext = searchContext;
			this.empAddContext = empAddContext;
			this.employeeViewModel = employeeViewModel;
			Currentpage = 1;
		}

		

		private async void btnSubmit_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = null;
			var caller = sender as Button;
			empAddContext.name = empNameTxtBox.Text;
			empAddContext.email = empEmailTxtBox.Text;
			if (!ValidationExtensions.IsValidEmailFormat(empAddContext.email))
			{
				MessageBox.Show("Provided email is not in valid formate, please retry!");
				return;
			}

			empAddContext.gender = comboBox1.Text;
			empAddContext.status = comboBox2.Text;
			await commandInvoker.InvokeAsync(caller.Tag.ToString(), caller.Name.ToString());
			
			dataGridView1.DataSource = employeeViewModel.Employees;
			if (employeeViewModel.Employees.Count > 0)
			{
				empNameTxtBox.Text = string.Empty;
				empEmailTxtBox.Text = string.Empty;
			}
			else
			{
				ErrorLabel.Text = "There has been some issue in saving the data, please read the log";
			}
		}

		private void Next_Click(object sender, EventArgs e)
		{
			var caller = sender as Button;
			searchContext.EmpName = textBox1.Text;
			Currentpage += 1;
			searchContext.page = Currentpage;
			commandInvoker.InvokeAsync("SearchCommand", "btnSearch");
			if (employeeViewModel.Employees?.Count > 0)
			{
				//panel2.Controls.Add(new EmployeeList(employeeViewModel));
				//label2.Hide();
				dataGridView1.DataSource = employeeViewModel.Employees;

				label8.Text = $"Page {Currentpage }/{  employeeViewModel.PaginationData.pagination.pages}";
			}
			else
			{
				label2.Text = $"Employee {textBox1.Text} is not found ,Please click on Add Employee tab to add.";
			}
		}

		private void Previous_Click(object sender, EventArgs e)
		{
			var caller = sender as Button;
			searchContext.EmpName = textBox1.Text;
			if (Currentpage > 1)
				Currentpage -= 1;
			searchContext.page = Currentpage;
			commandInvoker.InvokeAsync("SearchCommand", "btnSearch");
			if (employeeViewModel.Employees?.Count > 0)
			{
				//panel2.Controls.Add(new EmployeeList(employeeViewModel));
				//label2.Hide();
				dataGridView1.DataSource = employeeViewModel.Employees;

				int totalNumberOfPages = employeeViewModel.Employees.Count / 20;

				label8.Text = $"Page {Currentpage }/{  employeeViewModel.PaginationData.pagination.pages}";
			}
			else
			{
				label2.Text = $"Employee {textBox1.Text} is not found ,Please click on Add Employee tab to add.";
			}
		}

		private async void BtnSearch_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = null;
			var caller = sender as Button;
			searchContext.EmpName = textBox1.Text;
			searchContext.page = Currentpage=1;
			await commandInvoker.InvokeAsync(caller.Tag.ToString(), caller.Name.ToString());

			if (employeeViewModel.Employees?.Count > 0)
			{
				dataGridView1.DataSource = employeeViewModel.Employees;
				if (employeeViewModel.PaginationData != null)
					label8.Text = $"Page {Currentpage }/{ employeeViewModel.PaginationData.pagination.pages}";
			}
			else
			{
				label2.Text = $"Employee {textBox1.Text} is not found ,Please click on Add Employee tab to add.";
			}
		}

		private void btnSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				BtnSearch_Click(sender,e);
		}
	}
}
