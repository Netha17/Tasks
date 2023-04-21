using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    internal class AddStrategy : IStrategy
    {
        public void doOperation(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
