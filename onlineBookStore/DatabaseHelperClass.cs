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
        public List<ItemToPurchaseClass> getMostBoughtItems(string itemtype)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT S.itemid,S.picture,S.name,S.paymentamount,SUM(S.quantity) AS totalquantity FROM ShoppingCartTable S WHERE S.itemtype = @itemtype GROUP BY S.itemid, S.picture, S.name, S.paymentamount Order by totalquantity desc", connection);
            command.Parameters.AddWithValue("@itemtype", itemtype);

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
                    item.quantity = Convert.ToInt32(readShoppingCart["totalquantity"]);
                    item.product.price = Convert.ToDouble(readShoppingCart["paymentamount"]);
                    item.product.name = readShoppingCart["name"].ToString();
                    item.product.cover_page_picture = readShoppingCart["picture"].ToString();
                    list.Add(item);
                }
            }
            return list;
        }
        public List<ReportUserClass> getMostRichCustomers()
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT S.customerid,C.name,C.surname,SUM(S.paymentamount) AS totalpayment FROM ShoppingCartTable S, CustomerTable C WHERE S.customerid = C.id GROUP BY S.customerid, C.name, C.surname Order by totalpayment desc", connection);
            

            List<ReportUserClass> list = new List<ReportUserClass>();
            SqlDataReader read = command.ExecuteReader();
            if (read != null)
            {
                while (read.Read())
                {
                    ReportUserClass item = new ReportUserClass();
                    item.customerID = read["customerid"].ToString();
                    item.name = read["name"].ToString();
                    item.surName = read["surname"].ToString();
                    item.totalpayment = Convert.ToDouble( read["totalpayment"]);
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
            command.ExecuteNonQuery();
        }

        public List<BookClass> getAllBooksFromDB()
        {
            List<BookClass> books = new List<BookClass>();
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN

            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM BookTable", connection);

            SqlDataReader readBooks = command.ExecuteReader();
            if (readBooks != null)
            {
                while (readBooks.Read())
                {
                    BookClass book = new BookClass();
                    book.id = readBooks["id"].ToString();
                    book.name = readBooks["name"].ToString();
                    book.price = Convert.ToDouble(readBooks["price"]);
                    book.stock = Convert.ToInt32(readBooks["stock"]);
                    book.author = readBooks["author"].ToString();
                    book.publisher = readBooks["publisher"].ToString();
                    book.isbn = readBooks["isbn"].ToString();
                    book.page = Convert.ToInt32(readBooks["page"]);
                    book.cover_page_picture = readBooks["cover_page_picture"].ToString();
                    books.Add(book);
                }
            }
            return books;
        }

        public BookClass getABookFromDBByID(string id)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM BookTable WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            //Console.WriteLine("id " + Convert.ToInt32(id));
            SqlDataReader readBooks = command.ExecuteReader();
            BookClass book = new BookClass();
            if (readBooks != null)
            {
                while (readBooks.Read())
                {
                    Console.WriteLine(readBooks["id"].ToString());
                    book.id = readBooks["id"].ToString();
                    book.name = readBooks["name"].ToString();
                    book.price = Convert.ToDouble(readBooks["price"]);
                    book.stock = Convert.ToInt32(readBooks["stock"]);
                    book.author = readBooks["author"].ToString();
                    book.publisher = readBooks["publisher"].ToString();
                    book.isbn = readBooks["isbn"].ToString();
                    book.page = Convert.ToInt32(readBooks["page"]);
                    book.cover_page_picture = readBooks["cover_page_picture"].ToString();
                }
            }
            return book;
        }
        public static void addBookToDB2(ProductClass product)
        {
            Console.WriteLine("product.GetType(): " + product.GetType());
            Console.WriteLine("typeof(OnlineBookStore.BookClass): " + typeof(OnlineBookStore.BookClass));
            //if (product.GetType() == typeof(OnlineBookStore.BookClass))

            //    Console.WriteLine(((MagazineClass)product).issue);
                
        }


        
        public bool addAProductToDB(ProductClass product)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command  =null;
            if(product.GetType()==typeof(OnlineBookStore.BookClass))
            {
                command = new SqlCommand("INSERT INTO BookTable (name,price,stock,isbn,author,publisher,page,cover_page_picture) values(@name,@price,@stock,@isbn,@author,@publisher,@page,@cover_page_picture)", connection);
                command.Parameters.AddWithValue("@name", ((BookClass)product).name);
                command.Parameters.AddWithValue("@price", ((BookClass)product).price);
                command.Parameters.AddWithValue("@stock", ((BookClass)product).stock);
                command.Parameters.AddWithValue("@isbn", ((BookClass)product).isbn);
                command.Parameters.AddWithValue("@author", ((BookClass)product).author);
                command.Parameters.AddWithValue("@publisher", ((BookClass)product).publisher);
                command.Parameters.AddWithValue("@page", ((BookClass)product).page);
                command.Parameters.AddWithValue("@cover_page_picture", ((BookClass)product).cover_page_picture);
            }
            else if(product.GetType() == typeof(OnlineBookStore.MagazineClass))
            {
                command = new SqlCommand("INSERT INTO MagazineTable (name,price,stock,issue,type,cover_page_picture) values(@name,@price,@stock,@issue,@type,@cover_page_picture)", connection);
                command.Parameters.AddWithValue("@name", ((MagazineClass)product).name);
                command.Parameters.AddWithValue("@price", ((MagazineClass)product).price);
                command.Parameters.AddWithValue("@stock", ((MagazineClass)product).stock);
                command.Parameters.AddWithValue("@issue", ((MagazineClass)product).issue);
                command.Parameters.AddWithValue("@type", ((MagazineClass)product).magazineType);
                command.Parameters.AddWithValue("@cover_page_picture", ((MagazineClass)product).cover_page_picture);
            }
            else if(product.GetType() == typeof(OnlineBookStore.MusicCDsClass))
            {
                command = new SqlCommand("INSERT INTO MusicCDsTable (name,price,stock,singer,type,picture) values(@name,@price,@stock,@singer,@type,@picture)", connection);
                command.Parameters.AddWithValue("@name", ((MusicCDsClass)product).name);
                command.Parameters.AddWithValue("@price", ((MusicCDsClass)product).price);
                command.Parameters.AddWithValue("@stock", ((MusicCDsClass)product).stock);
                command.Parameters.AddWithValue("@singer", ((MusicCDsClass)product).singer);
                command.Parameters.AddWithValue("@type", ((MusicCDsClass)product).type);
                command.Parameters.AddWithValue("@picture", ((MusicCDsClass)product).cover_page_picture);
            }


            int affected = command.ExecuteNonQuery();

            if (affected > 0)
                return true;
            return false;
        }

        public bool addOrUpdateAUserFromDB(string operationType, string id, string name, string surname, string address, string email, string username, string password, bool isadmin)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command;
            if (operationType == "Add")
                command = new SqlCommand("INSERT INTO CustomerTable (name,surname,address,email,username,password,isadmin) values(@name,@surname,@address,@email,@username,@password,@isadmin)", connection);
            else if (operationType == "Update")
                command = new SqlCommand("UPDATE CustomerTable SET name=@name ,surname=@surname,address=@address,email=@email,username=@username,password=@password,isadmin=@isadmin where id=@id", connection);
            else
                return false; //Non supported operation
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@isadmin", isadmin ? 1 : 0);
            command.Parameters.AddWithValue("@id", id);
            int affected = 0;
            affected = command.ExecuteNonQuery();
            if (affected == 0)
                return false;
            else
                return true;
        }
        
        public bool deleteAnItemObjectFromDBByID(Type type,string id)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand deleteCommand = null;
            if (type == typeof(OnlineBookStore.UserClass))
                deleteCommand = new SqlCommand("delete from CustomerTable where id=@id", connection);
            if (type == typeof(OnlineBookStore.BookClass))
                deleteCommand = new SqlCommand("delete from BookTable where id=@id", connection);
            else if (type == typeof(OnlineBookStore.MagazineClass))
                deleteCommand = new SqlCommand("delete from MagazineTable where id=@id", connection);
            else if (type == typeof(OnlineBookStore.MusicCDsClass))
                deleteCommand = new SqlCommand("delete from MusicCDsTable where id=@id", connection);

            deleteCommand.Parameters.AddWithValue("@id", id);
            int affected = deleteCommand.ExecuteNonQuery();

            if (affected > 0)
                return true;
            return false;
        }


        public bool updateAProductAtDB(ProductClass product)
        {
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = null;
            if (product.GetType() == typeof(OnlineBookStore.BookClass))
            {
                command = new SqlCommand("UPDATE BookTable SET name=@name,price=@price,stock=@stock,isbn=@isbn,author=@author,publisher=@publisher,page=@page,cover_page_picture=@cover_page_picture WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", ((BookClass)product).id);
                command.Parameters.AddWithValue("@name", ((BookClass)product).name);
                command.Parameters.AddWithValue("@price", ((BookClass)product).price);
                command.Parameters.AddWithValue("@stock", ((BookClass)product).stock);
                command.Parameters.AddWithValue("@isbn", ((BookClass)product).isbn);
                command.Parameters.AddWithValue("@author", ((BookClass)product).author);
                command.Parameters.AddWithValue("@publisher", ((BookClass)product).publisher);
                command.Parameters.AddWithValue("@page", ((BookClass)product).page);
                command.Parameters.AddWithValue("@cover_page_picture", ((BookClass)product).cover_page_picture);
            }
            else if (product.GetType() == typeof(OnlineBookStore.MagazineClass))
            {
                command = new SqlCommand("UPDATE MagazineTable SET name=@name,price=@price,stock=@stock,issue=@issue,type=@type,cover_page_picture=@cover_page_picture WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", ((MagazineClass)product).id);
                command.Parameters.AddWithValue("@name", ((MagazineClass)product).name);
                command.Parameters.AddWithValue("@price", ((MagazineClass)product).price);
                command.Parameters.AddWithValue("@stock", ((MagazineClass)product).stock);
                command.Parameters.AddWithValue("@issue", ((MagazineClass)product).issue);
                command.Parameters.AddWithValue("@type", ((MagazineClass)product).magazineType);
                command.Parameters.AddWithValue("@cover_page_picture", ((MagazineClass)product).cover_page_picture);
            }
            else if (product.GetType() == typeof(OnlineBookStore.MusicCDsClass))
            {
                command = new SqlCommand("UPDATE MusicCDsTable SET name=@name,price=@price,stock=@stock,singer=@singer,type=@type,picture=@picture WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", ((MusicCDsClass)product).id);
                command.Parameters.AddWithValue("@name", ((MusicCDsClass)product).name);
                command.Parameters.AddWithValue("@price", ((MusicCDsClass)product).price);
                command.Parameters.AddWithValue("@stock", ((MusicCDsClass)product).stock);
                command.Parameters.AddWithValue("@singer", ((MusicCDsClass)product).singer);
                command.Parameters.AddWithValue("@type", ((MusicCDsClass)product).type);
                command.Parameters.AddWithValue("@picture", ((MusicCDsClass)product).cover_page_picture);
            }


            int affected = command.ExecuteNonQuery();

            if (affected > 0)
                return true;
            return false;
        }
        
        public DataTable getAllItemsForAClassFromATableByItsType(Type type)
        {
            SqlConnection connection = dbHelper.getConnection();
            DataTable dt = new DataTable();

            SqlDataAdapter command = null;
            if (type == typeof(OnlineBookStore.UserClass))
            {
                command = new SqlDataAdapter("SELECT * FROM CustomerTable", connection);
            }
            else if (type == typeof(OnlineBookStore.BookClass))
            {
                command = new SqlDataAdapter("SELECT * FROM BookTable", connection);
            }
            else if (type == typeof(OnlineBookStore.MagazineClass))
            {
                command = new SqlDataAdapter("SELECT * FROM MagazineTable", connection);
            }
            else if (type == typeof(OnlineBookStore.MusicCDsClass))
            {
                command = new SqlDataAdapter("SELECT * FROM MusicCDsTable", connection);
            }
            else
            {
                return null;
            }
            {
                command.Fill(dt);
            }
            return dt;
        }

        }


    }

