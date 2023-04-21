using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    public delegate void addDelegate(int m,int n);
    
    internal class CustomDelegate
    {
        public  void add(int m, int n)
        {
            Console.WriteLine(m + n);
        }
        public void subs(int m, int n)
        {
            Console.WriteLine(m - n);
        }
        public static void Main(string[] args)
        {
            CustomDelegate cd=new CustomDelegate();
            addDelegate ad = new addDelegate(cd.add);
            ad += cd.subs;

            ad(5, 5);
            Console.ReadLine();
        }
    }
}
