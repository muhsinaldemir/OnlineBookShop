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

        public void printProducts() { }
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

        public static void placeOrder(string customerID,double paymentAmount, PaymentType paymentType)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO ShoppingCartTable (customerid,itemid,itemtype,quantity,paymentamount,paymenttype) values(@customerid,@itemid,@itemtype,@quantity,@paymentamount,@paymenttype)", connection);

            foreach(var item in itemsToPurchase)
            {
                command.Parameters.Clear();
                string t = "";
                if (item.product is OnlineBookStore.BookClass)
                    t = "Book";
                else if (item.product is OnlineBookStore.MagazineClass)
                    t = "Magazine";
                else if (item.product is OnlineBookStore.MusicCDsClass)
                    t = "MusicCDs";
                Console.WriteLine("Type i budur: " + t);
                command.Parameters.AddWithValue("@customerid", customerID);
                command.Parameters.AddWithValue("@itemid", item.product.id);
                command.Parameters.AddWithValue("@itemtype", t);
                command.Parameters.AddWithValue("@quantity", item.quantity);
                command.Parameters.AddWithValue("@paymentamount", paymentAmount);
                command.Parameters.AddWithValue("@paymenttype", paymentType);
                command.ExecuteNonQuery();
            }
            //int affected = command.ExecuteNonQuery();

            //if (affected == 0)
            //{
            //}
        }
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
