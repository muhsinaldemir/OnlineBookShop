using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace OnlineBookStore
{
    class BookClass : ProductClass
    {
        public string isbn { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }

        public override void printProperties()
        {
            throw new NotImplementedException();// to do 
        }

        public BookClass()
        {

        }
        public BookClass(string Name, string Id, double Price, int Stock, string ISBN, string Author, string Publisher, int Page, string Cover_page_picture) : base(Name, Id, Price,Stock, Cover_page_picture)
        {
            isbn = ISBN;
            author = Author;
            publisher = Publisher;
            page = Page;
        }

        public static List<BookClass> getAllBooksFromDB()
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
                    //bool isAdmin = (bool)readCustomer["isadmin"];                          
                    book.id = readBooks["id"].ToString();
                    book.name = readBooks["name"].ToString();
                    book.price = Convert.ToDouble(readBooks["price"]);
                    book.stock = Convert.ToInt32(readBooks["stock"]);
                    book.author = readBooks["author"].ToString();
                    book.publisher = readBooks["publisher"].ToString();
                    book.isbn = readBooks["isbn"].ToString();
                    book.page = Convert.ToInt32(readBooks["page"]);
                    book.cover_page_picture = readBooks["cover_page_picture"].ToString();
                   // Console.WriteLine("While ici" + book.name);
                    books. Add(book);
                    
                }

            }
           
            return books;
        }


        public static BookClass getaBooksFromDBByID(string id)
        {
           
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN

            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM BookTable WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id",Convert.ToInt32(id));
            Console.WriteLine("id " + Convert.ToInt32(id));
            SqlDataReader readBooks = command.ExecuteReader();
            BookClass book = new BookClass();
            if (readBooks != null)
            {
                while (readBooks.Read())
                {
                    //bool isAdmin = (bool)readCustomer["isadmin"];      
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
                    // Console.WriteLine("While ici" + book.name);
                }
            }

            return book;
        }
    }
}
