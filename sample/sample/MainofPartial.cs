using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class MainofPartial
    {
        public static void Main(string[] args)
        {
            PartialStudent s=new PartialStudent("nithin",12);
            s.display();
            Console.ReadLine();
        }
    }
}
