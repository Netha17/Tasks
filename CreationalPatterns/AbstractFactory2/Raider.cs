using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class Raider : IBike
    {
        public void manufacture()
        {
            Console.WriteLine("Making raider");
        }
    }
}
