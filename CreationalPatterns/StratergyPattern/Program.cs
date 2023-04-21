using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new Substract());
            c.makeOperation(5, 6);
            Console.ReadLine();
        }
    }
}
