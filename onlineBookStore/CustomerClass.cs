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
       
        /** dbHelper created from DatabaseHelperClass 
        * A list of list in the  ItemToPurchaseClass' getAllUserPurchases() function is created.
        * myAccountUserControls array is created from the  MyAccountUserControl
        * The size of  myAccountUserControls is up to the length of list
        */

        public static MyAccountUserControl[] printCustomerPurchases(string customerID)
        {
            DatabaseHelperClass dbHelper = DatabaseHelperClass.Instance; //SINGLETON PATTERN
            List<ItemToPurchaseClass> list = dbHelper.getAllUserPurchases(Convert.ToInt32(customerID));
            MyAccountUserControl[] myAccountUserControls = new MyAccountUserControl[list.Count];

            int i = 0;
            Console.WriteLine("Customer Purchases are:");
            foreach (ItemToPurchaseClass item in list)
            {
                myAccountUserControls[i] = new MyAccountUserControl();
                myAccountUserControls[i].id = item.product.id;
                myAccountUserControls[i].name = item.product.name;
                myAccountUserControls[i].quantity = item.quantity;
                myAccountUserControls[i].unitPriceValue = item.product.price;
                myAccountUserControls[i].picture = item.product.cover_page_picture;
                Console.WriteLine("Id: " + item.product.id + " Name: " + item.product.name + " Quantity: " + item.quantity + " Unit Price Value: " + item.product.price + " Item Type: " + item.product.GetType());
                i++;
            }
            return myAccountUserControls;
        }
        /**
         * override function
         * @return false
         */ 
        public override bool isAdmin()
        {
            return false;
        }

        public override bool saveCustomer(string id, string name, string surname, string address, string email, string username, string password, bool isadmin)
        {
            bool operationResult = AdminUserClass.userOperations("Add", id, name, surname, address, email, username, password, isadmin);
            return operationResult;
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
        * @ brief Parameterized Constructor   
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
        /**   
        * Prints Customer Details   
        */
        public void printCustomerDetails()
        {
            Console.WriteLine("CustomerID: " + customerID, "  Name" + name + "  SurName:" + surName + "  Address" + address + " Email" + " UserName" + userName + " Password" + password + " IsAdmin" + (IsAdmin ? " Admin" : "Not Admin"));
        }
    }
}
