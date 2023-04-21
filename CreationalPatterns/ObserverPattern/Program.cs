using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher("Amazon");
            Publisher flipkart = new Publisher("Flipkart");
            Subscriber1 s1 = new Subscriber1("Nithin");
            Subscriber2 s2 = new Subscriber2("Kamala");
            Subscriber2 s3 = new Subscriber2("Ammmu");
            p.Subscribe(s1);
            p.Subscribe(s2);
            p.Subscribe(s3);
            flipkart.Subscribe(s1);
            flipkart.Subscribe(s2);
            p.LaunchProduct("Infinix Hot 15");
            flipkart.LaunchProduct("tukzer mobile stand");
            Console.ReadLine();
        }
    }
}
