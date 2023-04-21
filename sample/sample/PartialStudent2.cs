using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    public partial class PartialStudent
    {
        public PartialStudent(string n,int r)
         {
            name= n;
            rollno= r;

         }
         partial void Display()
         {
            Console.WriteLine("Name: " + name + " Rollno: " + rollno);
         }
    }
}
