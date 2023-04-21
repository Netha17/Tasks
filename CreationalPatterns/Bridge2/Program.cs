using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape2 shape= new Circle();
            shape.col = new Green();
            shape.drawShape();
            Console.ReadLine();

        }
    }
}
