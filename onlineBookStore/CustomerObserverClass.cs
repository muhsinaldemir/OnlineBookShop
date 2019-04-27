using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class CustomerObserverClass : ObserverClass
    {
        public override void update(string communicationType,string customerID, string name, double unitPriceValue)
        {
            if(communicationType=="email")
            {
                EmailClass email = new EmailClass("***REMOVED***", "denzemine@gmail.com", "emine deniz", 111, "***REMOVED***");
                Console.WriteLine("Cancel order in shopping cart");
                email.sendEmail();
            }
            else if(communicationType == "sms")
            {
                SMSClass sms = new SMSClass("OurNumber", "CustomerNumber", name ,unitPriceValue);
                sms.sendSMS();
            }
        }
    }
}
