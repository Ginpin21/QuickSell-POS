using System;
using System.Windows.Forms;

namespace QuickSell_POS
{
    public partial class LoginWindow : Form
    {
        private Employee currentEmployee;

        public LoginWindow()
        {
            InitializeComponent();
        }

        public Employee CurrentEmployee
        {
            get { return currentEmployee;}
            set { currentEmployee = value; }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxtInput.Text != "" && PasswordTxtInput.Text != "")
            {
                Employee loginEmployee= new Employee(UsernameTxtInput.Text, PasswordTxtInput.Text);
                DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
                currentEmployee = dbCon.UserAuthQuery(loginEmployee.Username, loginEmployee.Password);
                if(currentEmployee is object)
                {
                    DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                MessageBox.Show("Please all the fields", "Empty Field Error");
            }
            

        }

        private void UsernameTxtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
