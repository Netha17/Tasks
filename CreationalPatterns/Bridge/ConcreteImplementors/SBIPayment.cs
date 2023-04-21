using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class SBIPayment : IPayment
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using Sbi bank gateway for"+ paymentSystem);
        }
    }
}
