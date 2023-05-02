using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                switch (currentEmployee.Role)
                {
                    case "Admin":
                        Application.Run(new AdminWindow(currentEmployee));
                        break;
                    case "Manager":
                        Application.Run(new AdminWindow(currentEmployee));
                        break;
                    case "Cashier":
                        Application.Run(new AdminWindow(currentEmployee));
                        break;
                }

            }
        }
    }
}
