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
    public partial class ViewTodaySaleForm : UserControl
    {
        public ViewTodaySaleForm(Employee currentCashier)
        {
            InitializeComponent();
        }

        private void ViewTodaySaleForm_Load(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.FilterQuery("sale_details_view", "Date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
            MessageBox.Show(DateTime.Now.Date.ToString("yyyy-MM-dd"));
            SalesGridView.DataSource = dt;
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                SalesGridView.Columns[i].Width = 300;
            }
        }
    }
}
