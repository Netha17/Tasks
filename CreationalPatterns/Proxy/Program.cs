using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM a= new ATM();
            a.withdraw(5000);
            Console.WriteLine("Your balance is " + a.getBalance());
            Console.ReadLine();
        }
    }
}
