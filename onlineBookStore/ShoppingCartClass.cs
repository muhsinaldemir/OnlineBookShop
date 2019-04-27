﻿using System;
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

       // public ArrayList itemsToPurchase { get; set; }
        public static double paymentAmount { get; set; }
        public PaymentType paymentType { get; set; }
        /// create new  list object itemsToPurchase fromItemToPurchaseClass
        public static List<ItemToPurchaseClass> itemsToPurchase = new List<ItemToPurchaseClass>();


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
        public static void placeOrder(string customerID, PaymentType paymentType, double unitPriceValue)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            dbHelper.shoppingCartPlaceOrder(customerID, paymentType);
            sendInvoiceByEmail(unitPriceValue);
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
        public static void sendInvoiceByEmail(double unitPriceValue) { 

            notifyEmail(unitPriceValue);

        }
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
