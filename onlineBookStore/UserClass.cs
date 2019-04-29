using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace OnlineBookStore
{
    /// abstract class "UserClass"
    public abstract class UserClass
    {
        public string customerID { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool IsAdmin { get; set; }
        /**  
         * @brief Default Constructor
         * Constructs the object with default parameters  
         * @param string customerID
         * @param string name
         * @param string surName
         * @param string address
         * @param string email
         * @param string userName
         * @param string password
         * @param bool isAdmin
          */
        public UserClass(string customerID, string name, string surName, string address, string email, string userName, string password, bool isAdmin)
        {
            this.customerID = customerID;
            this.name = name;
            this.surName = surName;
            this.address = address;
            this.email = email;
            this.userName = userName;
            this.password = password;
            this.IsAdmin = isAdmin;
        }
        /**  
         * @brief Default Constructor
         * Constructs the object with default parameters  
          */
        public UserClass() { }
        ///abstract method ' isAdmin()'
        public abstract bool isAdmin();

        public abstract bool saveCustomer(string id, string name, string surname, string address, string email, string username, string password, bool isadmin);



        /**
         * add and update operation in the database
         * @param string operationType
         * @param string id
         * @param string name
         * @param string surName
         * @param string address
         * @param string email
         * @param string userName
         * @param string password
         * @param bool isAdmin
         */
        public static bool userOperations(string operationType, string id, string name, string surname, string address, string email, string username, string password, bool isadmin)
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
        /**
         * static userDelete() function
         * @param userID
         */ 
        public static bool userDelete(string userID)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance;
            bool affected = dbHelper.deleteAnItemObjectFromDBByID(typeof(OnlineBookStore.UserClass), userID);
            return affected;
            /*
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            SqlConnection connection = dbHelper.getConnection();
            SqlCommand deleteCommand = new SqlCommand("delete from CustomerTable where id=@id", connection);
            deleteCommand.Parameters.AddWithValue("@id", userID);
            deleteCommand.ExecuteNonQuery();
            int affected = 0;
            affected = deleteCommand.ExecuteNonQuery();
            if (affected == 0)
                return false;
            else
                return true;
                */
        }
    }
}
