﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal interface IFactory
    {
       IBike GetBike(string name);
    }
}
