using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
namespace OnlineBookStore
{
    public enum musicCDs_type
    {
        rock,
        rap,
        arabesk,
        pop,
        romance
    };
    /// create a new instance of MagazineClass from ProductClass
    class MusicCDsClass : ProductClass
    {
        public string singer { get; set; }
        /**  @brief Default Constructor
           * Constructs the object with default parameters  
           */
        public MusicCDsClass()
        {
        }
        /** @brief Default Constructor 
         * Constructs the object with default parameters 
         * @param string Name
         * @param string Id
         * @param double Price
         * @param int Stock
         * @param string singer
         * @param string picture
        */
        public MusicCDsClass(string Name, string Id, double Price, int Stock, string Singer,string Picture) : base(Name, Id, Price, Stock,Picture)
        {
            singer = Singer;
        }

        /**
 * A list of allMusicCDs in the MusicCDsClass' getAllMusicCDsFromDB() function is created.
 * musicCDsUserControls is created from the  MusicCDUserControl.
 * The size of musicCDsUserControls is up to the length of allMusicCDs.
*/
        public override void printProperties()
        {
            List<MusicCDsClass> allMusicCDs = MusicCDsClass.getAllMusicCDsFromDB();
            MusicCDUserControl[] musicCDsUserControls = new MusicCDUserControl[allMusicCDs.Count];

            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["BookShopForm"];

            if (((BookShopForm)f).flpHomePage.Controls.Count > 0)
                ((BookShopForm)f).flpHomePage.Controls.Clear();


            int i = 0;
            foreach (var item in allMusicCDs)
            {
                musicCDsUserControls[i] = new MusicCDUserControl();
                musicCDsUserControls[i].musicCDID = item.id;
                musicCDsUserControls[i].musicCDName = item.name;
                musicCDsUserControls[i].musicCDPrice = item.price;
                musicCDsUserControls[i].musicCDSinger = item.singer;
                musicCDsUserControls[i].stock = item.stock;
                musicCDsUserControls[i].picture = item.cover_page_picture;
                ((BookShopForm)f).flpHomePage.Controls.Add(musicCDsUserControls[i]);
                i++;
            }

        }
        /**
         * musicCDsList created from MusicCDsClass
         * this function reads musicCDs items in database
         * and add in musicCDsList
         * @return musicCDsList
         */
        public static List<MusicCDsClass> getAllMusicCDsFromDB()
        {
            List<MusicCDsClass> musicCDsList = new List<MusicCDsClass>();
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN

            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM MusicCDsTable", connection);

            SqlDataReader readMusicCDs = command.ExecuteReader();
            if (readMusicCDs != null)
            {
                while (readMusicCDs.Read())
                {
                    MusicCDsClass musicCDs = new MusicCDsClass();                        
                    musicCDs.id = readMusicCDs["id"].ToString();
                    musicCDs.name = readMusicCDs["name"].ToString();
                    musicCDs.price = Convert.ToDouble(readMusicCDs["price"]);
                    musicCDs.singer = readMusicCDs["singer"].ToString();
                    musicCDs.stock = Convert.ToInt32(readMusicCDs["stock"]);
                    musicCDs.cover_page_picture = readMusicCDs["picture"].ToString();
                    musicCDsList.Add(musicCDs);
                }
            }

            return musicCDsList;
        }
        /**this function read a musicCDs item in a database
        * @param string id
        * @return musicCDs
       */
        public static MusicCDsClass getAMusicCDsFromDB(string id)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM MusicCDsTable where id=@id", connection);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            SqlDataReader readMusicCDs = command.ExecuteReader();
            MusicCDsClass musicCDs = new MusicCDsClass();
            if (readMusicCDs != null)
            {
                while (readMusicCDs.Read())
                {                        
                    musicCDs.id = readMusicCDs["id"].ToString();
                    musicCDs.name = readMusicCDs["name"].ToString();
                    musicCDs.price = Convert.ToDouble(readMusicCDs["price"]);
                    musicCDs.singer = readMusicCDs["singer"].ToString();
                    musicCDs.stock = Convert.ToInt32(readMusicCDs["stock"]);
                    musicCDs.cover_page_picture = readMusicCDs["picture"].ToString();
                }
            }
            return musicCDs;
        }
    }
}
