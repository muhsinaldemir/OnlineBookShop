using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class CustomerObserverClass : ObserverClass
    {
        public override void update(string communicationType,UserClass user, string product_name, double unitPriceValue)
        {
            if(communicationType=="email")
            {
                EmailClass email = new EmailClass(AppConstants.EMAIL, user, product_name, unitPriceValue, AppConstants.EMAIL_PASSWORD);
                Console.WriteLine("Place order in shopping cart");
                email.sendEmail();
            }
            else if(communicationType == "sms")
            {
                SMSClass sms = new SMSClass(AppConstants.SMS_NUMBER, user.name, product_name, unitPriceValue);
                sms.sendSMS();
            }
        }
    }
}
