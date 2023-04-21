using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class Out_ref
    {
        static void SomeFunction(ref int insideVar)
        {
            
            insideVar += 10;
        }

        public static void Main()
        {
            int OutSideVar = 20;
            SomeFunction(ref OutSideVar);
            Console.WriteLine(OutSideVar);
            
           
        Console.ReadLine();
        }
    }
}
