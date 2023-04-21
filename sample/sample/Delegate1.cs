using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    //Declaration of delegate
    public delegate void MyDelegate(int a, int b);
    internal class Delegate1
    {
        public static void Add(int a, int b) 
        {
            Console.WriteLine(a + b);
            

        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a -b);

        }
        public static void Main(string[] args)
        {
            //Instantiation of delegate
            MyDelegate myDelegate = new MyDelegate(Add);
            myDelegate += Sub;
            //Invoking a delegate
            myDelegate(8, 4);
            Delegate[] delList=myDelegate.GetInvocationList();
            foreach (Delegate del in delList)
            {
                Console.WriteLine(del.ToString());
            }
            Console.ReadLine();

        }
        

    }
}
