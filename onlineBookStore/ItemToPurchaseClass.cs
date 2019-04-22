using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class ItemToPurchaseClass
    {
        public ProductClass product { get; set; }
        public int quantity { get; set; }
     

        public ItemToPurchaseClass()
        {
        }

        public ItemToPurchaseClass(ProductClass product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        //public ItemToPurchaseClass(string id)
        //{
        //    ProductClass product = new ProductClass();
        //    product.id = id;
        //}
    }
}
