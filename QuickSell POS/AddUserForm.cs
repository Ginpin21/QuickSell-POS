using System;
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
    public partial class AddUserForm : UserControl
    {
        public AddUserForm()
        {
            InitializeComponent();
            Dictionary<String, int> comboBoxList = new Dictionary<String, int>
            {
                {"Admin",1 },
                {"Manager",2 },
                {"Cashier",3 },

            };
            RoleDropDown.DataSource = new BindingSource(comboBoxList, null);
            RoleDropDown.DisplayMember = "Key";
            RoleDropDown.ValueMember = "Value";
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxtInput.Text != "" && PasswordTxtInput.Text != "" && CPasswordTxtInput.Text != "")
            {
                if(PasswordTxtInput.Text== CPasswordTxtInput.Text) {

                    Employee newEmployee = new Employee(UsernameTxtInput.Text, PasswordTxtInput.Text,RoleDropDown.Text);
                    DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
                    dbCon.AddEmployeeQuery(newEmployee);

                }
                else
                {
                    MessageBox.Show("Passwords must match", "Password Match Error");
                }
            }
        }
    }
}
