using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Facade
    {
        public void placeOrder()
        {
            Product p = new Product();
            p.GetProductDetails();
            Payment payment= new Payment(); ;
            payment.MakePayment();  
            Invoice invoice= new Invoice();
            invoice.SendInvoice();
            Console.WriteLine("order place successfully");
        }
    }
}
