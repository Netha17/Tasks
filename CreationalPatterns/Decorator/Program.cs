using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza p = new VegPizza();
            Brocoli b = new Brocoli(p);
            Console.WriteLine(b.getDesc());
            Console.WriteLine(b.getPrice());
            Console.ReadLine();
        }
    }
}
