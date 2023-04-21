using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "nithin";
            Type t1=s.GetType();
            Type t = typeof(String);
            Console.WriteLine(t+","+t1);
            
            Console.WriteLine(t1==t);
            
            object o = "netha";
            Console.WriteLine(typeof(object));
            Console.WriteLine(o.GetType());


            Console.ReadLine();
        }
    }
}
