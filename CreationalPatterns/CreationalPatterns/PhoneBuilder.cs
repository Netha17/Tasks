using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class PhoneBuilder
    {
        private string os;
       private int ram;
        private int price;
        private int camera;
        private int battery;
        
       public PhoneBuilder setOs(string os)
        {
            this.os = os;
            return this;
        }
        public PhoneBuilder setRam(int ram)
        {
            this.ram = ram; return this;
        }
        public PhoneBuilder setPrice(int price)
        {
            this.price = price; return this;
        }
        public PhoneBuilder setBattery(int battery)
        { this.battery = battery; return this;}
        public PhoneBuilder setCamera(int camera)
        {
            this.camera = camera; return this;  
        }
        public Phone Build()
        {
            return new Phone(os,ram,camera,price,battery);
        }
    }
}
