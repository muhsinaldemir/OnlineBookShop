using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace OnlineBookStore
{
    ///create a new BookClass instance of ProductClass
    class BookClass : ProductClass
    {
        public string isbn { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }

         /**
         * A list of allbooks in the book class' getAllBooksFromDB() function is created.
         * bookUserControlsis created from the  BookUserControl class.
         * The size of bookusercontrols is up to the length of allbooks.
        */

        public override void printProperties()
        {
            // throw new NotImplementedException();// to do 
            List<BookClass> allBooks = getAllBooksFromDB();
            BookUserControl[] bookUserControls = new BookUserControl[allBooks.Count];

            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];
          
            if (((BookShopForm)f).flpHomePage.Controls.Count > 0)
                ((BookShopForm)f).flpHomePage.Controls.Clear();

            int i = 0;
            foreach (var item in allBooks)
            {
                bookUserControls[i] = new BookUserControl();
                bookUserControls[i].bookID = item.id;
                bookUserControls[i].bookName = item.name;
                bookUserControls[i].bookAuthor = item.author;
                bookUserControls[i].bookPrice = item.price;
                bookUserControls[i].stock = item.stock;
                bookUserControls[i].cover_page_picture = item.cover_page_picture;
                ((BookShopForm)f).flpHomePage.Controls.Add(bookUserControls[i]);
                i++;
            }
        }
        /**   
         * @brief Default Constructor 
         * Constructs the object with default parameters
         */
        public BookClass()
        {

        }
        /**   
         * @brief Constructor 
         * Constructs the object with default parameters
         * this constructor inherit from product class so have already parameter Name, Id, Price,Stock, Cover_page_picture 
         * @param string Name
         * @param string Id
         * @param double Price
         * @param int Stock
         * @param string ISBN
         * @param string Author
         * @param string Publisher
         * @param int Page
         * @param string Cover_page_picture
         */
        public BookClass(string Name, string Id, double Price, int Stock, string ISBN, string Author, string Publisher, int Page, string Cover_page_picture) : base(Name, Id, Price,Stock, Cover_page_picture)
        {
            isbn = ISBN;
            author = Author;
            publisher = Publisher;
            page = Page;
        }
        /**
         * books list created from BookClass
         * this function reads book items in database
         * and add in books
         * @return book
         */
        public static List<BookClass> getAllBooksFromDB()
        {
            List<BookClass> books = new List<BookClass>();
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            books = dbHelper.getAllBooksFromDB();
            return books;
        }
        /**this function read book item in database
         * and assign bookclass parameter(id,name,price,stock,author,publisher,isbn,page,cover_page_picture)
        * @param string id
        * @return book
       */
        public static BookClass getaBooksFromDBByID(string id)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            BookClass book = new BookClass();
            book = dbHelper.getABookFromDBByID(id);
            return book;
        }
    }
}
