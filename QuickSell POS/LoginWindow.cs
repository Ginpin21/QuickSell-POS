using System;
using System.Windows.Forms;
using QuickSell_POS.Classes;

namespace QuickSell_POS
{
    public partial class LoginWindow : Form
    {
        // Atrribute for the currently logged in employee
        private Employee currentEmployee;

        public LoginWindow()
        {
            InitializeComponent();
        }

        public Employee CurrentEmployee
        {
            get { return currentEmployee;}
            set { currentEmployee = value;}
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxtInput.Text != "" && PasswordTxtInput.Text != "")
            {
                // Employee object to see if the credentials are correct
                Employee loginEmployee= new Employee(0,UsernameTxtInput.Text, PasswordTxtInput.Text,new Role());
                DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
               // Returns an employee object if credentials are correct 
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
