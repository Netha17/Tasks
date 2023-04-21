using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Truck:ITransport
    {
      public void deliver()
        {
            Console.WriteLine("delivering via truck");
        }
    }
}
