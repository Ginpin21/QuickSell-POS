using System;
using System.Windows.Forms;
using QuickSell_POS.Cashier;
using QuickSell_POS.Manager;
namespace QuickSell_POS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginWindow loginForm = new LoginWindow();
            Employee currentEmployee;

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    currentEmployee = loginForm.CurrentEmployee;

                    switch (currentEmployee.Role.RoleName)
                    {
                        case "Admin":
                            Application.Run(new AdminWindow(currentEmployee));
                            break;
                        case "Manager":
                            Application.Run(new ManagerWindow(currentEmployee));
                            break;
                        case "Cashier":
                            Application.Run(new CashierWindow(currentEmployee));
                            break;
                        default:
                            loginForm.Show();
                            break;
                    }
            }
        }
    }
}
