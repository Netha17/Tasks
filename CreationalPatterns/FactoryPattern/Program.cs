using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory= new Factory();
            ITransport it = factory.getInstance("Truck");
             it.deliver();
            Console.ReadLine();
        }
    }
}
