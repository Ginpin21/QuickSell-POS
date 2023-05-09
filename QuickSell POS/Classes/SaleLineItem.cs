using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSell_POS.Classes
{
    public class SaleLineItem : Product
    {
       
        private int productQuantity;

        public int Quantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        public SaleLineItem()
        {
            ProductID = 0;
            productName = "";
            ProductPrice = 0;
            ProductStock = 0;
            ProductCategory = new Category();
            productQuantity = 0;
        }

        public SaleLineItem(Product product , int qty)
        {
            ProductID = product.ProductID;
            productName = product.productName; 
            ProductPrice=product.ProductPrice;
            ProductStock = product.ProductStock;
            ProductCategory = product.ProductCategory;
            productQuantity = qty; 
        }
    }
}
