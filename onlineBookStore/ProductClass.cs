using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    abstract class ProductClass
    {
        public string name { get; set; }
        public string id { get; set; }
        public double price { get; set; }

        public abstract void printProperties();
        
        public ProductClass()
        {

        }
        public ProductClass(string Name ,string Id ,double Price)
        {
            name = Name;
            id = Id;
            price = Price;

        }

      
    }
}
