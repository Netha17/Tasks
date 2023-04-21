using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sample
{
    internal class async
    {
        public static void Main()
        {
            Method();
            Console.WriteLine("main thread");
            Console.ReadLine();
           
        }
        public static async void Method()
        {
           await Task.Run(new Action(LongTask));
                Console.WriteLine("new thread");
        }
        public static void LongTask()
        {
            Thread.Sleep(5000);
        }
    }
}
