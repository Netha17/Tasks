using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class Shine : IBike
    {
        public void manufacture()
        {
            Console.WriteLine("making shine bike");
        }
    }
}
