﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Volt
    {
        private int volt;
        public Volt(int volt)
        {
            this.volt = volt;
        }
        public int getVolt()
        {
            return volt;
        }
    }
}