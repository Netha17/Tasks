using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sample
{
    internal class mt
    {
        public static void test1()
        {
            for(int i=0; i<50; i++)
            {
                Console.WriteLine("Thread -1 "+i);
            }
            Console.WriteLine("test-1 thread exiting");
        }
        public static void test2()
        {
            for (int i = 51; i < 100; i++)
            {
                Console.WriteLine("Thread -2 "+i);
                if (i == 65)
                {
                    Console.WriteLine("test-2 thread supended");
                    Thread.Sleep(10000);
                    Console.WriteLine("test-2 thread wokeup");
                }
                    
            }
            Console.WriteLine("test-2 thread exiting");
        }
        public static void test3()
        {
            for (int i = 101; i < 150; i++)
            {
                Console.WriteLine("Thread -3 "+i);
            }
            Console.WriteLine("test-3 thread exiting");
        }
        public static void Main()
        {
            Console.WriteLine("main thread started");
            Thread t= Thread.CurrentThread;
            Console.WriteLine(t.Name);
            //test1();test2();test3();
            ThreadStart obj = new ThreadStart(test1);
            Thread t1=new Thread(test1);
            Thread t2=new Thread(test2);
            Thread t3=new Thread(test3);
            t1.Start();
            t2.Start();
            t3.Start();
            //t1.Join();
            //t2.Join();
            //t3.Join(); 
            Thread.Sleep(20000);
            Console.WriteLine("main thread exiting");
            Console.ReadLine();
        }
    }
}
