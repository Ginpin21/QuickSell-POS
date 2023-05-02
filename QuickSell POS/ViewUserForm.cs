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
        public ViewUserForm()
        {
            InitializeComponent();
        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            ArrayList l1 = dbCon.SelectAllQuery("employee_details_view");
            EmployeeGridView.DataSource= l1;
        }
    }
}
