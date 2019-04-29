using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class ReportUserClass : UserClass
    {
        public ReportUserClass()
        {
        }

        public double totalpayment { get; set; }

        public override bool isAdmin()
        {
            throw new NotImplementedException();
        }

        public override bool saveCustomer(string id, string name, string surname, string address, string email, string username, string password, bool isadmin)
        {
            throw new NotImplementedException();
        }
        public ReportUserClass(string id, string name, string surname, double totalpayment) : base(id, name, surname, null, null, null, null, false) { }
        
    }
}
