using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class CustomerClass : UserClass
    {
        public void printCustomerDetails() { }
        public void saveCustomer() { }
        public void printCustomerPurchases() { }

        public bool isAdmin() { return false; }

        private CustomerClass() : base() { }//singleton pattern
        private static CustomerClass customer = null;
        public static CustomerClass Instance
        {
            get
            {
                if (customer == null)
                {
                    customer = new CustomerClass();
                }
                return customer;
            }
        }

        public CustomerClass(string CustomerID, string Name, string SurName, string Address, string Email, string UserName, string Password, bool IsAdmin) : base(CustomerID, Name, SurName, Address, Email, UserName, Password, IsAdmin)
        {
            this.customerID = CustomerID;
            this.name = Name;
            this.surName = SurName;
            this.address = Address;
            this.email = Email;
            this.userName = UserName;
            this.password = Password;
            this.IsAdmin = IsAdmin;
        }


    }
}
