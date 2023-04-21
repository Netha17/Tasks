using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class VegPizza : IPizza
    {
        public string getDesc()
        {
            return "this is veg pizza";
        }

        public int getPrice()
        {
            return 100;
        }
    }
}
