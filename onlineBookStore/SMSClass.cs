using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class SMSClass
    {
        public string fromNumber { get; set; }
        public string toNumber { get; set; }
        public string productName { get; set; }
        public double totalValue { get; set; }

        public SMSClass(string fromNumber, string toNumber, string productName, double totalValue)
        {
            this.fromNumber = fromNumber;
            this.toNumber = toNumber;
            this.productName = productName;
            this.totalValue = totalValue;
        }

        public void sendSMS()
        {
            string message = "Dear Customer" + "\n\nYour Order from KitapKurdu has been cancelled. \n\nYour money will be returned in 3 work days.\n\n";
            message += "Cancelled Product Name: " + productName;
            message += "\nOrder Amount: " + totalValue + " TL" + "\n\nHave a nice day." + "\n\n KitapKurdu, Emine DENİZ & Muhsin ALDEMİR";

            Console.WriteLine("SMS is send\n" + message);
        }


    }
}
