using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 67, 39, 8, 61, 74, 82, 97, 27, 56, 49, 58, 79, 37 };
            var a=from obj in arr where obj>70 select obj;
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
