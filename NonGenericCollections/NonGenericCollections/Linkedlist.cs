using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class Linkedlist
    {
        public static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            LinkedListNode<string> node = list.AddFirst("Nithin");
            list.AddLast("Ale");
            list.AddAfter(node, "Netha");
            list.AddBefore(node, "Hello");
            Console.WriteLine("after insertion");
            foreach(var s in list)
            {
                Console.Write(s+" ");
            }
            list.RemoveFirst();
            list.RemoveLast();
            Console.WriteLine("after deletion");
            foreach (var s in list)
            {
                Console.Write(s + " ");
            }

            Console.ReadLine();

           
            
        }
    }
}
