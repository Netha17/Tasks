using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class CitiPayment : IPayment
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using citiBank gateway for "+ paymentSystem);
        }
    }
}
