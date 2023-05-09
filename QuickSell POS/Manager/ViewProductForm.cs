using QuickSell_POS.Classes;
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
    public partial class ViewProductForm : UserControl
    {
        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }
        public ViewProductForm()
        {
            InitializeComponent();
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("category");
            
            ProductPriceNumBox.Maximum = decimal.MaxValue;
            ProductStockNumBox.Maximum = int.MaxValue;
        }

        private void ViewProductForm_Load(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("product_details_view");
            ProductGridView.DataSource = dt;
            ProductGridView.Columns[0].Visible = false;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ProductGridView.Columns[i].Width = 300;
            }
           
        }

        private void ProductGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedProduct = new Product();
                selectedProduct.ProductID = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells[0].Value);
                ProductNameTxtInput.Text = ProductGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ProductStockNumBox.Value = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells[3].Value);
                ProductPriceNumBox.Value = Convert.ToDecimal(ProductGridView.Rows[e.RowIndex].Cells[2].Value);
                 //ProductCategoryDropDown.SelectedItem = ProductGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                EditPanel.Visible = true;
            }
        }

        private void SaveEditBtn_Click(object sender, EventArgs e)
        {
            selectedProduct.productName = ProductNameTxtInput.Text;
            selectedProduct.ProductStock = Convert.ToInt32(ProductStockNumBox.Value);
            selectedProduct.ProductPrice = Convert.ToDouble(ProductPriceNumBox.Value);
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            dbCon.UpdateProductQuery(selectedProduct);
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
          DialogResult confirmDelete = MessageBox.Show("Delete Product?", "Confirm delete", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
                dbCon.DeleteProductQuery(selectedProduct);
            }

        }
    }
}
