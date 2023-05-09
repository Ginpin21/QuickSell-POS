using QuickSell_POS.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSell_POS
{
    public partial class ViewUserForm : UserControl
    {
        Employee selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value; }
        }
        public ViewUserForm()
        {
            InitializeComponent(); DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("role");
            RoleDropDown.DataSource = dt;
            RoleDropDown.DisplayMember = "role_name";
            RoleDropDown.ValueMember = "role_id";

        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("employee_details_view");
            dt.Columns["Username"].ColumnName = "User";
            dt.Columns["Userpass"].ColumnName = "Password";
            dt.Columns["Userrole"].ColumnName = "Role";
            EmployeeGridView.DataSource = dt;
            EmployeeGridView.Columns[0].Visible = false;
            for (int i =0;i<dt.Columns.Count;i++) 
            {
                EmployeeGridView.Columns[i].Width = 300;
            }    
        }

        private void EmployeeGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedEmployee = new Employee();
                selectedEmployee.ID = Convert.ToInt32(EmployeeGridView.Rows[e.RowIndex].Cells[0].Value);
                UsernameTxtInput.Text = EmployeeGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                PasswordTxtInput.Text = EmployeeGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                RoleDropDown.Text = EmployeeGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                EditPanel.Visible = true;
            }
        }

        private void SaveEditBtn_Click(object sender, EventArgs e)
        {
            selectedEmployee.Username = UsernameTxtInput.Text;
            selectedEmployee.Password = PasswordTxtInput.Text;
            selectedEmployee.Role = new Role(Convert.ToInt32(RoleDropDown.SelectedValue),RoleDropDown.Text);
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            dbCon.UpdateEmployeeQuery(selectedEmployee);
        }
    }
}
