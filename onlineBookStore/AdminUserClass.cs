using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class AdminUserClass:UserClass
    {
        public AdminUserClass(string CustomerID, string Name, string SurName, string Address, string Email, string UserName, string Password, bool isAdmin):base(CustomerID,Name,SurName,Address,Email,UserName,Password, isAdmin)
        {
        }
        private AdminUserClass() : base() { }//singleton pattern

        public bool addCustomer() { return true; }
        public bool addNewBook() { return true; }
        public bool addNewMagazine() { return true; }
        public bool addNewMusicCD() { return true; }

        public override bool isAdmin()
        {
            return true;
        }

        private static AdminUserClass admin = null;
        public static AdminUserClass Instance
        {
            get
            {
                if (admin == null)
                {
                    admin = new AdminUserClass();
                }
                return admin;
            }
        }

    }
}
