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
        public static string customerID { get; set; }
        public static UserClass user { get; set; }

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
            customerID = customerID ?? throw new ArgumentNullException(nameof(customerID));
        }

        public static double paymentAmount { get; set; }
        public PaymentType paymentType { get; set; }

        /// create new  list object itemsToPurchase fromItemToPurchaseClass
        public static List<ItemToPurchaseClass> itemsToPurchase = new List<ItemToPurchaseClass>();

        //Observer Pattern Necessary Functions:
        private static List<ObserverClass> _observers = new List<ObserverClass>();

        public static void attach(ObserverClass observer)
        {
            _observers.Add(observer);
        }

        public static void detach(ObserverClass observer)
        {
            _observers.Remove(observer);
        }

        public static void notifyEmail(double unitPriceValue)
        {
            _observers.ForEach(o => { o.update("email", user,null,unitPriceValue); });
        }

        public static void notifySms(string name, double unitPriceValue)
        {
            _observers.ForEach(o => { o.update("sms",user, name, unitPriceValue); });
        }

        public static ShoppingCartItemsUserControl[] printProducts()
        {
            ShoppingCartItemsUserControl[] shoppingCartItemsUserControl = new ShoppingCartItemsUserControl[ShoppingCartClass.itemsToPurchase.Count];
               
            //Prepare items to show at shoppingcart 
            int i = 0;
            Console.WriteLine("Items in customers shopping cart are:");
            foreach (ItemToPurchaseClass item in ShoppingCartClass.itemsToPurchase)
            {
                shoppingCartItemsUserControl[i] = new ShoppingCartItemsUserControl();
                shoppingCartItemsUserControl[i].id = item.product.id;
                shoppingCartItemsUserControl[i].name = item.product.name;
                shoppingCartItemsUserControl[i].quantity = item.quantity;
                shoppingCartItemsUserControl[i].unitPriceValue = item.product.price;
                shoppingCartItemsUserControl[i].type = item.product.GetType();
                shoppingCartItemsUserControl[i].picture = item.product.cover_page_picture;
                //Print the item details to Console
                Console.WriteLine("Id: " + item.product.id + " Name: " + item.product.name + " Quantity: " + item.quantity + " Unit Price Value: " + item.product.price + " Item Type: " + item.product.GetType());
                i++;
            }
            return shoppingCartItemsUserControl;
        }

        /**@brief add itemToPurchase
         * @param ItemToPurchaseClass itemToPurchase
         */
        public static void addProduct(ItemToPurchaseClass itemToPurchase)
        {
            itemsToPurchase.Add(itemToPurchase);
        }
        
        /** @brief remove product() function
         * @param ItemToPurchaseClass itemToPurchase
         * calls remove() and   shoppingCartUpdate() function
         */
        public static void removeProduct(ItemToPurchaseClass itemToPurchase)
        {
            var element = itemsToPurchase.Find(el => el.product.id == itemToPurchase.product.id);
            itemsToPurchase.Remove(element);
        }

        /** @brief place order() function
         * @param string customerID
         * @param PaymentType paymentType
         * calls shoppingCartPlaceOrder() function
         */
        public static void placeOrder(string customerID, PaymentType paymentType, double unitPriceValue)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            dbHelper.shoppingCartPlaceOrder(customerID, paymentType);
            sendInvoiceByEmail(unitPriceValue);
            //itemsToPurchase.Clear();
        }
        /** @brief cancelorder() function
        * @param string string name
        * create a new object email from EmailClass
        * calls shoppingCartCancelOrder() and sendEmail() function
        */
        public static void cancelOrder(string name,double unitPriceValue)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            dbHelper.shoppingCartCancelOrder(name);
            notifySms(name,unitPriceValue);
        }
        public static void sendInvoiceByEmail(double unitPriceValue)
        { 
            notifyEmail(unitPriceValue);
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
