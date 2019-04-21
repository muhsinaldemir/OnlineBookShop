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
    class MusicCDsClass : ProductClass
    {
        public string singer { get; set; }

        public MusicCDsClass()
        {
        }

        public MusicCDsClass(string Name, string Id, double Price, int Stock, string Singer) : base(Name, Id, Price, Stock)
        {
            singer = Singer;
        }

        public override void printProperties()
        {
            throw new NotImplementedException();
        }
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
                    //bool isAdmin = (bool)readCustomer["isadmin"];                          
                    musicCDs.id = readMusicCDs["id"].ToString();
                    musicCDs.name = readMusicCDs["name"].ToString();
                    musicCDs.price = Convert.ToDouble(readMusicCDs["price"]);
                    musicCDs.singer = readMusicCDs["singer"].ToString();
                    musicCDs.stock = Convert.ToInt32(readMusicCDs["stock"]);

                    // musicCDs. = musicCDsList["type"].ToString();

                    // Console.WriteLine("While ici" + book.name);
                    musicCDsList.Add(musicCDs);

                }

            }

            return musicCDsList;
        }
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
                  
                    //bool isAdmin = (bool)readCustomer["isadmin"];                          
                    musicCDs.id = readMusicCDs["id"].ToString();
                    musicCDs.name = readMusicCDs["name"].ToString();
                    musicCDs.price = Convert.ToDouble(readMusicCDs["price"]);
                    musicCDs.singer = readMusicCDs["singer"].ToString();
                    musicCDs.stock = Convert.ToInt32(readMusicCDs["stock"]);

                    // musicCDs. = musicCDsList["type"].ToString();

                    // Console.WriteLine("While ici" + book.name);
                   

            }
            return musicCDs;
        }
    }
}
