using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace OnlineBookStore
{
    public enum magazine_type
    {
        Actual,
        News,
        Sports,
        Computer,
        Technology
    };

    class MagazineClass : ProductClass
    {
        public string issue { get; set; }
        public magazine_type magazineType { get; set; }

        public override void printProperties()
        {
            throw new NotImplementedException();
        }
        public MagazineClass()
            {}

        public MagazineClass(string Name,string Id,double Price,int Stock,string Issue,magazine_type MagazineType,string Cover_page_picture):base(Name,Id,Price, Stock, Cover_page_picture)
        {
            issue = Issue;
            magazineType = MagazineType;
        }
        public static List<MagazineClass> getAllMagazineFromDB()
        {
            List<MagazineClass> magazineList = new List<MagazineClass>();
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN

            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM MagazineTable", connection);

            SqlDataReader readMagazine = command.ExecuteReader();
            if (readMagazine != null)
            {
                while (readMagazine.Read())
                {
                    MagazineClass magazine = new MagazineClass();
                    //bool isAdmin = (bool)readCustomer["isadmin"];                          
                    magazine.id = readMagazine["id"].ToString();
                    magazine.name = readMagazine["name"].ToString();
                    magazine.price = Convert.ToDouble(readMagazine["price"]);
                    magazine.stock = Convert.ToInt32(readMagazine["stock"]);
                    magazine.issue = readMagazine["issue"].ToString();
                    magazine.cover_page_picture= readMagazine["cover_page_picture"].ToString();
                    //  magazine.magazineType = readMagazine["type"].ToString();

                    // Console.WriteLine("While ici" + book.name);
                    magazineList.Add(magazine);

                }

            }

            return magazineList;
        }
        public static MagazineClass getAMagazineFromDB(string id)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN

            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM MagazineTable where id=@id", connection);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            SqlDataReader readMagazine = command.ExecuteReader();

            MagazineClass magazine = new MagazineClass();
            if (readMagazine != null)
            {
                while (readMagazine.Read())
                {

                    //bool isAdmin = (bool)readCustomer["isadmin"];                          
                    magazine.id = readMagazine["id"].ToString();
                    magazine.name = readMagazine["name"].ToString();
                    magazine.price = Convert.ToDouble(readMagazine["price"]);
                    magazine.stock = Convert.ToInt32(readMagazine["stock"]);
                    magazine.issue = readMagazine["issue"].ToString();
                    magazine.cover_page_picture= readMagazine["cover_page_picture"].ToString();
                    //  magazine.magazineType = readMagazine["type"].ToString();

                    // Console.WriteLine("While ici" + book.name);

                }
               
            }

            return magazine;
        }
    }
}
