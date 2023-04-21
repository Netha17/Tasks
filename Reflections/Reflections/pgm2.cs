using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Reflections
{
    internal class pgm2
    {
        public static void Main()
        {
            //string path = @"";
            // Assembly a = Assembly.LoadFile(path);
           // Type[] t = a.GetTypes();
           Type t= typeof(string);
            PropertyInfo[] p = t.GetProperties();
            
            foreach(PropertyInfo pi in p)
            {
                Console.WriteLine(pi.Name);
            }
            Console.WriteLine("class: " + t.Name);
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo mi in methods)
            {
                Console.WriteLine("Method: "+mi.Name+": "+mi.ReturnType);
                ParameterInfo[] parameters = mi.GetParameters();
                foreach (ParameterInfo pi in parameters)
                { Console.WriteLine(pi.Name+": "+pi.ParameterType);
                }
            }
            Console.ReadLine();
        }
    }
}
