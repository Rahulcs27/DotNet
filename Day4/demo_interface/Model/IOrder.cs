﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_interface.Model
{
    interface IOrder
    {
        void processOrder();
        void cancelOrder();
    }
}
