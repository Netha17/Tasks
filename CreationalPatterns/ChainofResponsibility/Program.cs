using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the difficulty level of the question");
            int diffculty_level = int.Parse(Console.ReadLine());
            IHandler h1 = new Handler1();
            
            IHandler h2= new Handler2();
            
            IHandler h3 = new Handler3();
            
            h1.setHandler(h2);
            h2.setHandler(h3);
            h1.operation(diffculty_level);

            Console.ReadLine();
        }
    }
}
