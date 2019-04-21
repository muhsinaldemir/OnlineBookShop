﻿using System;
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
        public bool addProduct(ItemToPurchaseClass itemToPurchase) { return true; }
        public bool removeProduct(ItemToPurchaseClass itemToPurchase) { return true; }
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
