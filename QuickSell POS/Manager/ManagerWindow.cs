using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSell_POS.Manager
{
    public partial class ManagerWindow : Form
    {
        UserControl currentForm;
        public ManagerWindow(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentUserLabel.Text += currentEmployee.Username;
            CurrentRoleLabel.Text += currentEmployee.Role.RoleName;
            SwitchForms(new ManagerHomeForm());
        }
        private void SwitchForms(UserControl form)
        {
            if (currentForm != form)
            {
                MainPanel.Controls.Remove(currentForm);
                currentForm = form;
                currentForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(currentForm);
                MainPanel.Tag = currentForm;
                ActiveWindowLabel.Text = currentForm.AccessibleName;
                currentForm.BringToFront();
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new AddCategoryForm());
        }

        private void HomeNavBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new ManagerHomeForm());

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new AddProductForm());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewProductBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new ViewProductForm());
        }
    }
}
