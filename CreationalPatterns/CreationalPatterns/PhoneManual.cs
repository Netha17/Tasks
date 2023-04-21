using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class PhoneManual
    {
        int price;
        int battery;
        int camera;
        int ram;
        string os;
        string processor;
        public PhoneManual(int price, int ram,int battery, int camera, string os, string processor)
        {
            this.price = price;
            this.battery = battery;
            this.camera = camera;
            this.ram = ram;
            this.os = os;
            this.processor = processor;
        }
        public void show()
        {
            Console.WriteLine("done phone manual");
        }
    }
    
}
