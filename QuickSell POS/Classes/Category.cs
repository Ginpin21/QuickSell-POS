using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSell_POS.Classes
{
    public class Category
    {
        private int categoryID;
        private string categoryName; 
        private string categoryDescription;

        public Category()
        {
            categoryName = "";
            categoryDescription = "";
        }
        public Category(int id,string name, string desc)
        {
            categoryID = id;
            categoryName = name;
            categoryDescription = desc;
        }

        public int ID
        {
            get { return categoryID; } 
            set { categoryID = value; }
        }
        public string Name 
        { 
            get { return categoryName; } 
            set { categoryName = value; }
        }
        public string Description
        {
            get { return categoryDescription; }
            set { categoryDescription = value; }
        }



    }
}
