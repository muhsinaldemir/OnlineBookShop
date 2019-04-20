using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class AdminUserClass:UserClass
    {
        public AdminUserClass(string CustomerID, string Name, string SurName, string Address, string Email, string UserName, string Password, bool isAdmin):base(CustomerID,Name,SurName,Address,Email,UserName,Password, isAdmin)
        {
        }

        public AdminUserClass():base(){ }

        public bool addCustomer() { return true; }
        public bool addNewBook() { return true; }
        public bool addNewMagazine() { return true; }
        public bool addNewMusicCD() { return true; }

        public override bool isAdmin()
        {
            return true;
        }
    }
}
