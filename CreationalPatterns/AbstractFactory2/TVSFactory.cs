using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class TVSFactory: IFactory
    {
        public IBike GetBike(string bike)
        {
            if (bike == "raider")
                return new Raider();
            else if (bike == "apache")
                return new Apache();
            else
                return null;
        }
    }
}
