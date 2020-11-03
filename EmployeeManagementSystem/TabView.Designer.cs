namespace EmployeeManagementSystem
{
	partial class TabView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.Next = new System.Windows.Forms.Button();
			this.Previous = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.empEmailTxtBox = new System.Windows.Forms.TextBox();
			this.empNameTxtBox = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(751, 262);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(743, 233);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Employee Search";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.comboBox2);
			this.tabPage2.Controls.Add(this.comboBox1);
			this.tabPage2.Controls.Add(this.empEmailTxtBox);
			this.tabPage2.Controls.Add(this.empNameTxtBox);
			this.tabPage2.Controls.Add(this.btnSubmit);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(743, 233);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Add Employee";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.Next);
			this.panel1.Controls.Add(this.Previous);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(737, 227);
			this.panel1.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(577, 178);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 17);
			this.label8.TabIndex = 8;
			this.label8.Text = "Page : ";
			// 
			// Next
			// 
			this.Next.Location = new System.Drawing.Point(643, 175);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(75, 23);
			this.Next.TabIndex = 7;
			this.Next.Text = "Next";
			this.Next.UseVisualStyleBackColor = true;
			// 
			// Previous
			// 
			this.Previous.Location = new System.Drawing.Point(466, 175);
			this.Previous.Name = "Previous";
			this.Previous.Size = new System.Drawing.Size(75, 23);
			this.Previous.TabIndex = 6;
			this.Previous.Text = "Previous";
			this.Previous.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(434, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = " Note : If search crietria is not provided , all results will be displayed.";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(40, 83);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(108, 23);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Tag = "SearchCommand";
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(108, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
			this.comboBox2.Location = new System.Drawing.Point(179, 161);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 24);
			this.comboBox2.TabIndex = 17;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.comboBox1.Location = new System.Drawing.Point(180, 120);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 16;
			// 
			// empEmailTxtBox
			// 
			this.empEmailTxtBox.Location = new System.Drawing.Point(179, 82);
			this.empEmailTxtBox.Name = "empEmailTxtBox";
			this.empEmailTxtBox.Size = new System.Drawing.Size(121, 22);
			this.empEmailTxtBox.TabIndex = 15;
			// 
			// empNameTxtBox
			// 
			this.empNameTxtBox.Location = new System.Drawing.Point(179, 47);
			this.empNameTxtBox.Name = "empNameTxtBox";
			this.empNameTxtBox.Size = new System.Drawing.Size(121, 22);
			this.empNameTxtBox.TabIndex = 14;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(449, 117);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 13;
			this.btnSubmit.Tag = "EmpAddCommand";
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(92, 161);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Status";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(92, 123);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Gender:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(92, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Email:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(92, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Emp Name:";
			// 
			// TabView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Name = "TabView";
			this.Size = new System.Drawing.Size(751, 268);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Next;
		private System.Windows.Forms.Button Previous;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox empEmailTxtBox;
		private System.Windows.Forms.TextBox empNameTxtBox;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
	}
}
