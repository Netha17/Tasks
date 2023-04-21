﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class NetBanking : Payment
    {
        public override void MakePayment()
        {
            payment.ProcessPayment("net banking");
        }
    }
}
