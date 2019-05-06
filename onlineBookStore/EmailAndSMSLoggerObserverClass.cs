using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class EmailAndSMSLoggerObserverClass : ObserverClass
    {
        public override void update(string communicationType, UserClass user, string name, double unitPriceValue)
        {
            //string message = "{0} is sent to UserName " + user.userName + " UserEmail: " + user.email + " for product: " + name + " with price: " + unitPriceValue + "Time: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            if (communicationType == "email")
            {
                string message = "Email is sent to UserName " + user.userName + " UserEmail: " + user.email + " for product: " + name + " with price: " + unitPriceValue + " Time: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                FileWriterClass.WriteFile(AppConstants.EMAIL_LOG_FILE_LOCATION, message);
                Console.WriteLine("Email Log: {0}", message);
            }
            else if (communicationType == "sms")
            {
                string message = "SMS is sent to UserName " + user.userName + " UserEmail: " + user.email + " for product: " + name + " with price: " + unitPriceValue + " Time: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                FileWriterClass.WriteFile(AppConstants.SMS_LOG_FILE_LOCATION, message);
                Console.WriteLine("SMS Log: {0}", message);
            }
        }
    }
}
