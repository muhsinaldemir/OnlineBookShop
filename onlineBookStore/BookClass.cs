using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class BookClass : ProductClass
    {
        public string isbn { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }
        public string cover_page_picture { get; set; }

        public override void printProperties()
        {
            throw new NotImplementedException();// to do 
        }

        public BookClass()
        {

        }
        public BookClass(string name,string id,double price,string ISBN,string Author,string Publisher,int Page,string Cover_page_picture):base(name,id,price)
        {
            isbn = ISBN;
            author = Author;
            publisher = Publisher;
            page = Page;
            cover_page_picture = Cover_page_picture;
        }

    }
}
