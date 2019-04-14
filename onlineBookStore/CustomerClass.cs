using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class CustomerClass
    {
        public string customerID { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public void printCustomerDetails() { }
        public void saveCustomer() { }
        public void printCustomerPurchases() { }

        private CustomerClass() { }//singleton pattern
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

        public CustomerClass(string CustomerID, string Name, string SurName, string Address, string Email, string UserName, string Password)
        {
            customerID = CustomerID;
            name = Name;
            surName = SurName;
            address = Address;
            email = Email;
            userName = UserName;
            password = Password;
        }
    }
}
