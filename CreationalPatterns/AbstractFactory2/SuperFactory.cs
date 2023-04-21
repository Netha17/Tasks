using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class SuperFactory
    {
        public static IFactory GetFactory(string name)
        {
            if (name == "honda")
                return new HondaFactory();
            else if (name == "tvs")
                return new TVSFactory();
            else
                return null;

        }
    }
}
