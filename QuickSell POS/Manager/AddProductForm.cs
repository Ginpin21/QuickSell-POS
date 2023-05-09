using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickSell_POS.Classes;

namespace QuickSell_POS.Manager
{
    public partial class AddProductForm : UserControl
    {
        public AddProductForm()
        {
            InitializeComponent();
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("category");
            ProductCategoryDropDown.DataSource = dt;
            ProductCategoryDropDown.DisplayMember = "cat_name";
            ProductCategoryDropDown.ValueMember = "cat_id";
            ProductPriceNumBox.Maximum = decimal.MaxValue;
            ProductStockNumBox.Maximum = int.MaxValue;

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductNameTxtInput.Text != "")
            {
                DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
                Product newProduct = new Product(0
                    , ProductNameTxtInput.Text
                    , Convert.ToDouble(ProductPriceNumBox.Value)
                    , Convert.ToInt32(ProductStockNumBox.Value)
                    , new Category(Convert.ToInt32(ProductCategoryDropDown.SelectedValue), ProductCategoryDropDown.SelectedText, ""));
                dbCon.AddProductQuery(newProduct);
                ProductNameTxtInput.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field Error");
            }

        }
    }
}
