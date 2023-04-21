using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class NonVeg : IPizza
    {
        public string getDesc()
        {
            return "Get Non veg pizza";
        }

        public int getPrice()
        {
            return 150;
        }
    }
}
