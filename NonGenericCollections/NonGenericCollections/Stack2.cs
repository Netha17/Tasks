using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class Stack2
    {
        public static void Main(string[] args)
        {
            Stack s= new Stack();   
            s.Push(1);
            s.Push(2);
            s.Pop();
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Pop();
            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
            
        }
    }
}
