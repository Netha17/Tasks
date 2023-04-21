using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class PhoneManualBuilder
    {
        private int battery;
        private int price;
        private int camera;
        private int ram;
        private string os;
        private string processor;
        public PhoneManualBuilder setBattery(int battery)
        { this.battery = battery;
            return this;
        }
        public PhoneManualBuilder setPrice(int price)
        {
            this.price = price; return this;
        }
        public PhoneManualBuilder setCamera(int camera)
        { this.camera = camera; return this;}  
        public PhoneManualBuilder setRam(int ram)
        { this.ram = ram; return this;}
        public  PhoneManualBuilder setOs(string os)
        { this.os = os; return this;}
        public PhoneManualBuilder setProcessor(string processor)
        { this.processor = processor; return this;}
        public PhoneManual Build()
        {
            return new PhoneManual(price,ram,battery,camera,os,processor);
        }
    }
}
