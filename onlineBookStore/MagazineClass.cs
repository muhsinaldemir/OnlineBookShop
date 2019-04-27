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
    /// create a new instance of MagazineClass
    class MagazineClass : ProductClass
    {
        public string issue { get; set; }
        public magazine_type magazineType { get; set; }

        /**
       * A list of allmagazine in the  MagazineClass' getAllMagazineFromDB() function is created.
       * magazineUserControls is created from the  MagazineUserControls
       * The size of  MagazineUserControls is up to the length of allmagazine
      */
        public override void printProperties()
        {
            List<MagazineClass> allmagazine = MagazineClass.getAllMagazineFromDB();
            MagazineUserControl[] magazineUserControls = new MagazineUserControl[allmagazine.Count];

            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];

                if (((BookShopForm)f).flpHomePage.Controls.Count > 0)
                    ((BookShopForm)f).flpHomePage.Controls.Clear();

            int i = 0;
            foreach (var item in allmagazine)
            {
                magazineUserControls[i] = new MagazineUserControl();
                magazineUserControls[i].magazineID = item.id;
                magazineUserControls[i].magazineName = item.name;
                magazineUserControls[i].magazinePrice = item.price;
                magazineUserControls[i].magazineIssue = item.issue;
                magazineUserControls[i].stock = item.stock;
                magazineUserControls[i].cover_page_picture = item.cover_page_picture;
                ((BookShopForm)f).flpHomePage.Controls.Add(magazineUserControls[i]);
                i++;
            }
        }
        /**  @brief Default Constructor
         * Constructs the object with default parameters  
         */
        public MagazineClass()
         {}
        /** @brief Default Constructor 
         * Constructs the object with default parameters 
         * @param string Name
         * @param string Id
         * @param double Price
         * @param int Stock
         * @param string Issue
         * @param magazine_type MagazineType
         * @param string Cover_page_picture
        */
        public MagazineClass(string Name,string Id,double Price,int Stock,string Issue,magazine_type MagazineType,string Cover_page_picture):base(Name,Id,Price, Stock, Cover_page_picture)
        {
            issue = Issue;
            magazineType = MagazineType;
        }
        /**
         * magazineList created fromMagazineClass
         * this function reads magazine items in database
         * and add in magazinelist
         * @return magazineList
         */
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
                    magazine.id = readMagazine["id"].ToString();
                    magazine.name = readMagazine["name"].ToString();
                    magazine.price = Convert.ToDouble(readMagazine["price"]);
                    magazine.stock = Convert.ToInt32(readMagazine["stock"]);
                    magazine.issue = readMagazine["issue"].ToString();
                    magazine.cover_page_picture= readMagazine["cover_page_picture"].ToString();
                    magazineList.Add(magazine);
                }
            }
            return magazineList;
        }
        /**this function read amagazine item in a database
         * @param string id
         * @return magazine
        */
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
                    magazine.id = readMagazine["id"].ToString();
                    magazine.name = readMagazine["name"].ToString();
                    magazine.price = Convert.ToDouble(readMagazine["price"]);
                    magazine.stock = Convert.ToInt32(readMagazine["stock"]);
                    magazine.issue = readMagazine["issue"].ToString();
                    magazine.cover_page_picture= readMagazine["cover_page_picture"].ToString();
                }
            }
            return magazine;
        }
    }
}
