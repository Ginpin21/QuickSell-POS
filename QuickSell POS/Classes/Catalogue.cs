using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSell_POS.Classes
{
    public class Catalogue
    {
        private Product[] productCatalogue;

        public Product[] ProductCatalogue 
        {
            get { return productCatalogue; }
            set { productCatalogue = value; }
        }

    }
}
