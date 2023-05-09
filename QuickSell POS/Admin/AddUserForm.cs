using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickSell_POS.Classes;
namespace QuickSell_POS
{
    public partial class AddUserForm : UserControl
    {
        public AddUserForm()
        {
            InitializeComponent();
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("role");
            RoleDropDown.DataSource = dt;
            RoleDropDown.DisplayMember = "role_name";
            RoleDropDown.ValueMember = "role_id";
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxtInput.Text != "" && PasswordTxtInput.Text != "" && CPasswordTxtInput.Text != "")
            {
                if(PasswordTxtInput.Text== CPasswordTxtInput.Text) {

                    Employee newEmployee = new Employee(0,UsernameTxtInput.Text, PasswordTxtInput.Text,new Role(Convert.ToInt32(RoleDropDown.SelectedValue),RoleDropDown.SelectedText));
                    DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
                    dbCon.AddEmployeeQuery(newEmployee);
                    UsernameTxtInput.Text = "";
                    PasswordTxtInput.Text = "";
                    CPasswordTxtInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Passwords must match", "Password Match Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field Error");
            }
        }
    }
}
