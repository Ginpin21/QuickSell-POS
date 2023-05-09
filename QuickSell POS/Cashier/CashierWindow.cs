using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSell_POS.Cashier
{
    public partial class CashierWindow : Form
    {
        private UserControl currentForm;
        private Employee currentEmployee;
        public Employee CurentEmployee 
        {
            get { return currentEmployee; }
            set { currentEmployee = value; }
        }

        public CashierWindow(Employee currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
            CurrentUserLabel.Text += currentEmployee.Username;
            CurrentRoleLabel.Text += currentEmployee.Role.RoleName;
            SwitchForms(new CashierHomeForm());
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

        private void CreateSaleNavBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new CreateSaleForm(currentEmployee));
        }

        private void ViewSaleNavBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new ViewTodaySaleForm(currentEmployee));

        }

        private void HomeNavBtn_Click(object sender, EventArgs e)
        {
            SwitchForms(new CashierHomeForm());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
