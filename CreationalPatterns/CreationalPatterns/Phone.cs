using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    internal class Phone
    {
        string os;
        int ram;
        int price;
        int camera;
        int battery;
        public Phone(string os,int ram,int price,int camera,int battery)

        {
            this.os = os;   
            this.ram = ram;
                this.price = price;
            this.camera = camera;
            this.battery = battery;


        }
        public void show()
        {
            Console.WriteLine("Phone has successfully built with features like"+os+","+ram+","+price+","+camera+","+battery);   
        }
        
    }
}
