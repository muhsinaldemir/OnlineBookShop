using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    /// CustomerClass inherited from UserClass

    public class CustomerClass : UserClass
    {
        public void printCustomerDetails() { }
        public void saveCustomer() { }
        public void printCustomerPurchases() { }
        /**
         * override function
         * @return false
         */ 
        public override bool isAdmin()
        {
            return false;
        }

        /**   
         *userclass have constructor so customerclass should have constructor
         */
        private CustomerClass() : base() { }//singleton pattern
        ///Initialize static member of CustomerClass
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
        /**   
        * @ brief Default Constructor   
        * Constructs the object with default parameters  
        * @param string CustomerID
        * @param string Name
        * @param string SurName
        * @param string Address
        * @param  string Email
        * @param string UserName
        * @param string Password  
        * @param bool IsAdmin
        */
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
