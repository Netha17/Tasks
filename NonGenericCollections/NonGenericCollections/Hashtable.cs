using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class Hashtable_2
    {
        public static void Main(string[] args)
        {
           
            Hashtable h = new Hashtable();
            h.Add(1, "Nitin");
            h.Add(2, "Kamala");
            foreach(var s in h.Keys)
            {
                Console.WriteLine(h[s]);
            }
            Console.WriteLine(h.ContainsKey(1));
            Console.WriteLine(h.ContainsValue("raju"));//returns false due to no element existence
            Console.ReadLine();
        }
    }
}
