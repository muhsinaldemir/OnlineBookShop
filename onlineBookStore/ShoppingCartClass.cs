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
        /// create new  list object itemsToPurchase fromItemToPurchaseClass
        public static List<ItemToPurchaseClass> itemsToPurchase = new List<ItemToPurchaseClass>();

        public void printProducts()
        {

        }
        /**@brief add itemToPurchase
         * @param ItemToPurchaseClass itemToPurchase
         */
        public static void addProduct(ItemToPurchaseClass itemToPurchase)
        {
            itemsToPurchase.Add(itemToPurchase);
        }
        ///shoppingCartUpdate() function
         
        private static void shoppingCartUpdate()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
            ((BookShopForm)f).populateShoppingCartPanelView();
        }
        /** @brief remove product() function
         * @param ItemToPurchaseClass itemToPurchase
         * calls remove() and   shoppingCartUpdate() function
         */
        public static void removeProduct(ItemToPurchaseClass itemToPurchase)
        {
            var element = itemsToPurchase.Find(el => el.product.id == itemToPurchase.product.id);
            itemsToPurchase.Remove(element);
            shoppingCartUpdate();
        }
        /** @brief place order() function
         * @param string customerID
         * @param PaymentType paymentType
         * calls shoppingCartPlaceOrder() function
         */
        public static void placeOrder(string customerID, PaymentType paymentType)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            dbHelper.shoppingCartPlaceOrder(customerID, paymentType);

        }
        /** @brief cancelorder() function
        * @param string string name
        * create a new object email from EmailClass
        * calls shoppingCartCancelOrder() and sendEmail() function
        */
        public static void cancelOrder(string name)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            dbHelper.shoppingCartCancelOrder(name);
            EmailClass email = new EmailClass("***REMOVED***","denzemine@gmail.com","emine deniz",111,"***REMOVED***");
            Console.WriteLine("Cancel order in shopping cart");
            email.sendEmail();

        }
        public bool sendInvoiceByEmail() { return true; }
        /**   
         * @brief Default Constructor
         * Constructs the object with default parameters 
         */
        private ShoppingCartClass()
        {
        }
        ///Initialize static member of ShoppingCartClass
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
        /**   
         * @brief Default Constructor
         * Constructs the object with default parameters 
         * @param string customerID
         */

        private ShoppingCartClass(string customerID)
        {
            this.customerID = customerID ?? throw new ArgumentNullException(nameof(customerID));
        }
        /** @brief  calculateActualTotalPrice() function
         * @return totalPrice
         */
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
