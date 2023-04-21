using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class HondaFactory: IFactory
    {
        public IBike GetBike(string name)
        {
            if (name == "unicorn")
                return new Unicorn();
            else if (name == "shine")
                return new Shine();
            else
                return null;
        }
    }
}
