using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{


    public delegate void CustomDelegate1(string msg);

        class EventProgram
        {
        public event CustomDelegate1 CustomEvent;
        public static void  Greeting(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Main(string[] args)
        {
            EventProgram ep= new EventProgram();    
            ep.CustomEvent=new CustomDelegate1(Greeting);
            if(ep.CustomEvent!=null)
            {
                ep.CustomEvent("Hello Nithin");
            }
            Console.ReadLine();

        }
            
        }
}
