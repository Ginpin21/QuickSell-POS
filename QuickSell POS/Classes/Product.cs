using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSell_POS.Classes
{
    public class Product
    {
        private int productID;
        public string productName;
        private double productPrice;
        private int productStock;
        private Category productCategory;
        
        public int ProductID 
        { 
            get { return productID; }
            set { productID = value; }
        }
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public int ProductStock
        {
            get { return productStock; }
            set { productStock = value; }
        }
        public Category ProductCategory
        {
            get { return productCategory; }
            set { productCategory = value; }
        }

        public Product()
        {
            productID = 0;
            productName = "";
            productPrice = 0.0;
            productStock = 0;
            productCategory = new Category();
        }
        public Product (int id,string name, double price, int stock, Category category)
        {   
            productID = id;
            productName = name;
            productPrice = price;
            productStock = stock;
            productCategory = category;
        }
    }
}
