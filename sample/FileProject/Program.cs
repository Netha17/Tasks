using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\Practice\\Nithi.txt";
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Hello fucker");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string s = sr.ReadToEnd();
                Console.WriteLine(s);
                Console.WriteLine(sr);
            }
            
            //StreamReader sr= new StreamReader(path);    
            //string s= sr.ReadToEnd();
            //Console.WriteLine(s);

            if (File.Exists(path))
            {
                Console.WriteLine("file exists");
                File.Delete(path);
            }
            Console.ReadLine();

        }
    }
}
