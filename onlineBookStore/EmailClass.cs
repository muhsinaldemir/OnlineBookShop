using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    ///class  "EmailClass
    public class EmailClass
    {
        public string fromAddress { get; set; }
        public UserClass user { get; set; }
        public string productName { get; set; }
        public double totalValue { get; set; }
        public string password { get; set; }

        /**   
         * @brief Default Constructor
         * Constructs the object with default parameters 
         * @param string fromAddress
         * @param string toAddress
         * @param string customerName
         * @param double totalValue
         * @param string password
         */
        public EmailClass(string fromAddress, UserClass user, string productName, double totalValue, string password)
        {
            this.fromAddress = fromAddress;
            this.user = user;
            this.productName = productName;
            this.totalValue = totalValue;
            this.password = password;
        }
        /** 
         * @brief Default Constructor 
         * Constructs the object with default parameters   
         */
        public EmailClass() { }
        
        /// send email

        public void sendEmail()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(fromAddress, password);
            string message = "Dear " + user.name + " " + user.surName + "\n\n Your Order from KitapKurdu has been placed. \n\n Your items will be sent shortly.\n\n";
            message += "\nOrder Amount: " + totalValue + " TL" +  "\n\nHave a nice day." + "\n\n KitapKurdu, Emine DENİZ & Muhsin ALDEMİR";

            MailMessage mm = new MailMessage(fromAddress, user.email, "Your Order" +
                "Information", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            //Console.WriteLine("Email Class in Email Class");
            //client.Send(mm);

        }
    }
}
