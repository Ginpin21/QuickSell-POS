using QuickSell_POS.Classes;
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

namespace QuickSell_POS.Cashier
{
    public partial class CreateSaleForm : UserControl
    {
        private ArrayList saleItems= new ArrayList{};
        private double grandTotal = 0;
        private Employee currentEmployee;
        public ArrayList SaleItems
        {
            get { return saleItems; }
            set { saleItems = value; }
        }
        public double GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }
        public CreateSaleForm(Employee currentEmployee)
        {
            InitializeComponent();
            // Setting the current cashier
            this.currentEmployee = currentEmployee;
            // Fetching the categories for the filter
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("category");
            dt.Rows.Add(new object[] { 0,"All" });
            ProductCategoryDropDown.DataSource = dt;
            ProductCategoryDropDown.DisplayMember = "cat_name";
            ProductCategoryDropDown.ValueMember = "cat_id";
            ProductCategoryDropDown.SelectedValue = 0;
            //
            GrandTotalLabel.Text = GrandTotal.ToString();
        }


        private void CreateSaleForm_Load(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt = dbCon.SelectAllQuery("product_details_view");
            ProductGridView.DataSource = dt;
            for (int i = 2; i <= dt.Columns.Count+1; i++)
            {
                ProductGridView.Columns[i].Width = 300;
                ProductGridView.Columns[i].ReadOnly = true;
            }

            ProductGridView.Columns[0].DisplayIndex = dt.Columns.Count + 1;
            ProductGridView.Columns[1].DisplayIndex = dt.Columns.Count + 1;

            ProductGridView.Columns[0].ReadOnly = false;
            ProductGridView.Columns[1].ReadOnly = false;

            ProductGridView.Columns[2].Visible = false;
        }

        private void FilterProductsBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
            DataTable dt;
            if (ProductCategoryDropDown.Text!="All") {
                dt = dbCon.FilterQuery("product_details_view","Category",ProductCategoryDropDown.Text);
            }
            else
            {
                dt = dbCon.SelectAllQuery("product_details_view"); 
            }
            ProductGridView.DataSource = dt;
            ProductGridView.Columns[2].Visible = false;
            for (int i = 2; i < dt.Columns.Count; i++)
            {
                ProductGridView.Columns[i].MinimumWidth = 200;
            }
        }

        private void ProductGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ProductGridView.Rows[e.RowIndex];
                if (Convert.ToInt32(selectedRow.Cells[0].Value) > 0)
                    if(Convert.ToInt32(selectedRow.Cells[0].Value) <= Convert.ToInt32(selectedRow.Cells[5].Value)) {
                        {
                            SaleLineItem item = new SaleLineItem();
                            item.ProductID = Convert.ToInt32(selectedRow.Cells[2].Value);
                            item.productName = selectedRow.Cells[3].Value.ToString();
                            item.ProductPrice = Convert.ToDouble(selectedRow.Cells[4].Value);
                            item.ProductStock = Convert.ToInt32(selectedRow.Cells[5].Value);
                            item.ProductCategory.Name = selectedRow.Cells[6].Value.ToString();
                            item.Quantity = Convert.ToInt32(selectedRow.Cells[0].Value);
                            string[] itemRow = new string[] {
                        item.productName,
                        item.ProductPrice.ToString(),
                        item.Quantity.ToString(),
                        (item.Quantity* item.ProductPrice).ToString()
                    };
                            GrandTotal += item.ProductPrice*item.Quantity;
                            GrandTotalLabel.Text = GrandTotal.ToString();
                            SaleItemsGridView.Rows.Add(itemRow);
                            SaleItems.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantity cannot be more than stock", "Excess quantity error");
                    }
                else
                {
                    MessageBox.Show("Quantity cannot be 0", "Zero quantity error");
                }
            }
        }
        // Methods for handling the input of quantity in ProductGridView
        private void ProductGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(QtyBtnColumn_KeyPress);
            if (ProductGridView.CurrentCell.ColumnIndex == 0)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(QtyBtnColumn_KeyPress);
                }
            }
        }
        private void QtyBtnColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Methods for handling the input of quantity in ProductGridView

        private void SaleItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                SaleItemsGridView.Rows.RemoveAt(e.RowIndex);
                foreach (SaleLineItem item in SaleItems.ToArray())
                {
                    if (saleItems.IndexOf(item) == e.RowIndex)
                    {
                        GrandTotal -= item.ProductPrice * item.Quantity;
                        GrandTotalLabel.Text = GrandTotal.ToString();
                        saleItems.RemoveAt(e.RowIndex);
                    }
                }
            }


        }
        private void CompleteSaleBtn_Click(object sender, EventArgs e)
        {
            if (SaleItems.Count != 0)
            {
                Sale currentSale = new Sale(0, GrandTotal,currentEmployee,DateTime.Now,true,0,saleItems);
                DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
                int saleID = dbCon.CreateSaleQuery(currentSale);
                foreach(SaleLineItem item in SaleItems)
                {
                    Product updatedProduct = new Product(item.ProductID, item.productName, item.ProductPrice, (item.ProductStock - item.Quantity), item.ProductCategory);
                    dbCon.AddSaleProductQuery(saleID, item);
                    dbCon.UpdateProductQuery(updatedProduct);
                }
                GrandTotal = 0;
                SaleItemsGridView.Rows.Clear();
                SaleItems.Clear();
            }
        }

        
    }
}
