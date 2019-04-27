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
        public string toAddress { get; set; }
        public string customerName { get; set; }
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
        public EmailClass(string fromAddress, string toAddress, string customerName, double totalValue, string password)
        {
            this.fromAddress = fromAddress;
            this.toAddress = toAddress;
            this.customerName = customerName;
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
            string message = "Dear " + customerName + "\n\n Your Order from KitapKurdu has been cancelled. \n\n Your money will be returned in 3 work days.\n\n";
            message += "Order Amount: " + totalValue + " Euro" +  "\n\nHave a nice day." + "\n\n KitapKurdu, Emine DENİZ & Muhsin ALDEMİR";

            MailMessage mm = new MailMessage(fromAddress, toAddress, "Information", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Email Class in Email Class");
            client.Send(mm);

        }
    }
}
