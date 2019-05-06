using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    abstract class ObserverClass
    {
        public abstract void update(string communicationType,UserClass user, string product_name, double unitPriceValue);
    }
}
