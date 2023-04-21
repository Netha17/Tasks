using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher("Amazon");
            Subscriber subscriber = new Subscriber("Nithin");
            Subscriber2 subscriber2 = new Subscriber2("Kamala");
            publisher.launchProduct("Infinix Hot 12 Mobile");
            Console.WriteLine("HI");
            publisher.getSubscribers();
            Console.ReadLine();

            

        }
    }
}
