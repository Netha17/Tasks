using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Ship: ITransport
    {
        public void deliver()
        {
            Console.WriteLine("delivering via ship");
        }
    }
}
