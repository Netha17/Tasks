using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class Programcs
    {
        public static void Main(string[] args)
        {
            Template t = new ConcreteHouse();
            t.BuildHouse();
            Template t2 = new WoodenHouse();
            t2.BuildHouse();
            Console.ReadLine();

        }
    }
}
