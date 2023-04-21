using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class list
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("Before sorting");
            foreach(var item in list)
            {
                Console.WriteLine(item);    
            }
            list.Sort();
            Console.WriteLine("After sorting");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Reverse();
            Console.WriteLine("After reversing");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
