﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    abstract class ObserverClass
    {
        public abstract void update(string communicationType,string customerID, string name, double unitPriceValue);
    }
}
