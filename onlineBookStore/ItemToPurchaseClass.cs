using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    ///  class of "ItemToPurchaseClass"
    public class ItemToPurchaseClass
    {
        public ProductClass product { get; set; }
        public int quantity { get; set; }

        /** 
        * @brief Default Constructor
        * Constructs the object with default parameters
        */ 
       public ItemToPurchaseClass()
       {
       }
       /** 
        * @brief Default Constructor
        * Constructs the object with default parameters
        * @param ProductClass product
        * @param int quantity
        */
        public ItemToPurchaseClass(ProductClass product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
