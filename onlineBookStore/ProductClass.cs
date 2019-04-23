using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public abstract class ProductClass
    {
        public string name { get; set; }
        public string id { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public string cover_page_picture { get; set; }
        public abstract void printProperties();
        
        public ProductClass()
        {

        }
        public ProductClass(string Name ,string Id ,double Price, int Stock, string Cover_Page_Picture)
        {
            name = Name;
            id = Id;
            price = Price;
            stock = Stock;
            cover_page_picture = Cover_Page_Picture;
        }

      
    }
}
