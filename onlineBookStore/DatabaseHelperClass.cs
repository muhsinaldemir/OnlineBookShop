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
        SqlConnection connection = new SqlConnection(@"Server=tcp: oop2.database.windows.net;Database=bookshop; User ID = oop2admin@oop2.database.windows.net; Password=oop2_project;Trusted_Connection=False; Encrypt=True;");

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
            if(connection.State != ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            return connection;
        }

    }
}
