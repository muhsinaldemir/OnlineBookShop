using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace OnlineBookStore
{
    class DatabaseHelperClass
    {
        private SqlConnection connection = new SqlConnection(@"Server=tcp: oop2.database.windows.net;Database=bookshop; User ID = oop2admin@oop2.database.windows.net; Password=oop2_project;Trusted_Connection=False; Encrypt=True;");

        /**
         * create a new object dbhelper from DatabaseHelperClass
         * and initialized
         */ 
        private static DatabaseHelperClass dbHelper = null;

        public static DatabaseHelperClass Instance
        {
            get
            {
                if (dbHelper == null)
                {
                    dbHelper = new DatabaseHelperClass();
                }
                return dbHelper;
            }
        }
        /// connect to sqlconnection
        
        public SqlConnection getConnection()
        {
            connection.Close();
            connection.Open();
            return connection;
        }
        /**
         * 
         * @param string customerID
         * @param PaymentType paymentType
         */
        public void shoppingCartPlaceOrder(string customerID, PaymentType paymentType)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO ShoppingCartTable (customerid,itemid,name,itemtype,quantity,paymentamount,paymenttype,picture) values(@customerid,@itemid,@name,@itemtype,@quantity,@paymentamount,@paymenttype,@picture)", connection);

            foreach (var item in ShoppingCartClass.itemsToPurchase)
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
                command.Parameters.AddWithValue("@name", item.product.name);
                command.Parameters.AddWithValue("@itemtype", t);
                command.Parameters.AddWithValue("@quantity", item.quantity);
                command.Parameters.AddWithValue("@paymentamount", item.product.price);
                command.Parameters.AddWithValue("@paymenttype", paymentType);
                command.Parameters.AddWithValue("@picture", item.product.cover_page_picture);
                command.ExecuteNonQuery();
            }
        }

        public void shoppingCartCancelOrder(string name)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("DELETE FROM ShoppingCartTable WHERE name=@name)", connection);
            command.Parameters.AddWithValue("@name", name);
        }
        /**@brief getAllUserPurchases() function
         * 
         * @param int userID
         */

        public List<ItemToPurchaseClass> getAllUserPurchases(int userID)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM ShoppingCartTable WHERE customerid=@id", connection);
            command.Parameters.AddWithValue("@id", userID);

            List<ItemToPurchaseClass> list = new List<ItemToPurchaseClass>();
            SqlDataReader readShoppingCart = command.ExecuteReader();
            if (readShoppingCart != null)
            {
                while (readShoppingCart.Read())
                {
                    ItemToPurchaseClass item = new ItemToPurchaseClass();
                    ProductClass book = new BookClass();
                    item.product = book;
                    item.product.id = readShoppingCart["itemid"].ToString();
                    item.quantity = Convert.ToInt32(readShoppingCart["quantity"]);
                    item.product.price = Convert.ToDouble(readShoppingCart["paymentamount"]);
                    item.product.name = readShoppingCart["name"].ToString();
                    item.product.cover_page_picture = readShoppingCart["picture"].ToString();
                    list.Add(item);
                }
            }
            return list;
        }

        public void removeSelectedItemsFromShoppingCart(string name)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("DELETE FROM ShoppingCartTable WHERE name=@name", connection);
            command.Parameters.AddWithValue("@name", name);
        }
    }
}
