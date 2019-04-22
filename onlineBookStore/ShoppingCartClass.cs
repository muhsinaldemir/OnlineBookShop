using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public enum PaymentType
    {
        Cash,
        CreditCard
    };

    class ShoppingCartClass
    {
        public string customerID { get; set; }
       // public ArrayList itemsToPurchase { get; set; }
        public double paymentAmount { get; set; }
        public PaymentType paymentType { get; set; }
        public static List<ItemToPurchaseClass> itemsToPurchase = new List<ItemToPurchaseClass>();

        public void printProducts() { }
        public static void addProduct(ItemToPurchaseClass itemToPurchase)
        {
            itemsToPurchase.Add(itemToPurchase);
        }

        private static void shoppingCartUpdate()
        {
            ShoppingCartItemsUserControl[] shoppingCartItemsUserControl = new ShoppingCartItemsUserControl[ShoppingCartClass.itemsToPurchase.Count];

            BookShopForm bookShopForm = new BookShopForm();
            if (bookShopForm.flpShoppingCart.Controls.Count > 0)
                bookShopForm.flpShoppingCart.Controls.Clear();

            int i = 0;
            foreach (ItemToPurchaseClass item in ShoppingCartClass.itemsToPurchase)
            {
                shoppingCartItemsUserControl[i] = new ShoppingCartItemsUserControl();
                shoppingCartItemsUserControl[i].id = item.product.id;
                shoppingCartItemsUserControl[i].name = item.product.name;
                shoppingCartItemsUserControl[i].quantity = item.quantity;
                shoppingCartItemsUserControl[i].unitPriceValue = item.product.price;
                bookShopForm.flpShoppingCart.Controls.Add(shoppingCartItemsUserControl[i]);
                i++;
            }

        }
        public static void removeProduct(ItemToPurchaseClass itemToPurchase)
        {
            var element = itemsToPurchase.Find(el => el.product.id == itemToPurchase.product.id);
            itemsToPurchase.Remove(element);
            shoppingCartUpdate();
        }

        public bool placeOrder() { return true; }
        public bool cancelOrder() { return true; }
        public bool sendInvoiceByEmail() { return true; }

        private ShoppingCartClass()
        {
        }

        private static ShoppingCartClass shoppingCart = null;
        public static ShoppingCartClass Instance
        {
            get
            {
                if (shoppingCart == null)
                {
                    shoppingCart = new ShoppingCartClass();
                }
                return shoppingCart;
            }
        }

        private ShoppingCartClass(string customerID)
        {
            this.customerID = customerID ?? throw new ArgumentNullException(nameof(customerID));
            //this.itemsToPurchase = itemsToPurchase ?? throw new ArgumentNullException(nameof(itemsToPurchase));
        }
    }
}
