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

        public SqlConnection getConnection()
        {

            /* if(connection.State != ConnectionState.Open)
             {
                 connection.Close();
                 connection.Open();
             }*/
            connection.Close();
            connection.Open();
            return connection;
        }

        public void shoppingCartPlaceOrder(string customerID, PaymentType paymentType)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("INSERT INTO ShoppingCartTable (customerid,itemid,itemtype,quantity,paymentamount,paymenttype) values(@customerid,@itemid,@itemtype,@quantity,@paymentamount,@paymenttype)", connection);

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
                command.Parameters.AddWithValue("@itemtype", t);
                command.Parameters.AddWithValue("@quantity", item.quantity);
                command.Parameters.AddWithValue("@paymentamount", item.product.price);
                command.Parameters.AddWithValue("@paymenttype", paymentType);
                command.ExecuteNonQuery();
            }

        }
    }
}
