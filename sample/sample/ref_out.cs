using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class ref_out
    {
            public static void operation(int n1,int n2,out int add,out int sub,out int mul)
        {

            add = n1 + n2;
            mul = n1 * n2;
            sub= n1 - n2;
        }
        public static void Main(string[] args)
        {
            int add, sub, mul;
            operation(10,20,out add,out sub,out mul);
            Console.WriteLine(add + "" + sub + " " + mul);
            Console.ReadLine();
        }
    }
}
