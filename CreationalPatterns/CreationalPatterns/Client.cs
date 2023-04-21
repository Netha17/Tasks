using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            //PhoneBuilder builder = new PhoneBuilder();
            //Phone phone = builder.setPrice(15000).setRam(8).setCamera(64).Build();
            //phone.show();
            Phone phone=new PhoneBuilder().setPrice(15000).setRam(8).Build();
            PhoneManualBuilder manual = new PhoneManualBuilder();
            PhoneManual phonemanual=manual.setRam(8).Build();
            phonemanual.show();
            Console.ReadLine(); 

        }
    }
}
