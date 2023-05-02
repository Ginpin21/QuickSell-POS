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
    public partial class AdminWindow : Form
    {
        UserControl currentForm = new AdminHomeForm();
        public AdminWindow(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentUserLabel.Text += currentEmployee.Username;
            CurrentRoleLabel.Text += currentEmployee.Role;
            ActiveWindowLabel.Text = currentForm.AccessibleName;
            currentForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(currentForm);
            MainPanel.Tag = currentForm;


        }
        private void SwitchForms(UserControl form)
        {
            if (currentForm != form) 
            {
                MainPanel.Controls.Remove(currentForm);
                currentForm = form;
                currentForm.Dock=DockStyle.Fill;
                MainPanel.Controls.Add(currentForm);
                MainPanel.Tag = currentForm;
                ActiveWindowLabel.Text = currentForm.AccessibleName;
            }
        }
        private void AddUserNavBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new AddUserForm());
        }

        private void ViewUserNavBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new ViewUserForm());
        }

        private void HomeNavBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new AdminHomeForm());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
