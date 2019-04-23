using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void printProducts()
        {

        }
        public static void addProduct(ItemToPurchaseClass itemToPurchase)
        {
            itemsToPurchase.Add(itemToPurchase);
        }

        public static void debug2()
        {
            foreach (var item in ShoppingCartClass.itemsToPurchase)
            {
                Console.WriteLine("Quantity change in debug: " + item.product.name + "  " + item.quantity);
            }
        }
        private static void shoppingCartUpdate()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
            ((BookShopForm)f).populateShoppingCartPanelView();
        }
        public static void removeProduct(ItemToPurchaseClass itemToPurchase)
        {
            var element = itemsToPurchase.Find(el => el.product.id == itemToPurchase.product.id);
            itemsToPurchase.Remove(element);
            shoppingCartUpdate();
        }

        public static void placeOrder(string customerID, PaymentType paymentType)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            dbHelper.shoppingCartPlaceOrder(customerID, paymentType);

        }

        public static void cancelOrder(string name)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            dbHelper.shoppingCartCancelOrder(name);
            EmailClass email = new EmailClass("***REMOVED***","denzemine@gmail.com","emine deniz",111,"***REMOVED***");
            Console.WriteLine("Cancel order in shopping cart");
            email.sendEmail();

        }
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

        public static double calculateActualTotalPrice()
        {
            double totalPrice = 0;
            foreach(var item in itemsToPurchase)
            {
                totalPrice += item.product.price * item.quantity;
            }
            return totalPrice;
        }
    }
}
