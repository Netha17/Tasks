using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class SuperFactory
    {
        public static IFactory GetFactory(string factoryType)
        {
            if (factoryType == "land")
                return new LandAnimalFactory();
            else if (factoryType == "sea")
                return new SeaAnimalFactory();
            else
                return null;
        }
    }
}
