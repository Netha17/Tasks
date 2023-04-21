using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sample
{
    internal class FilePractice
    {

        public static void Main()
        {
            string path = "C:\\Practice\\nithin.txt";
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
           StreamWriter sw=new StreamWriter(path);
            sw.WriteLine("nihtin");
            sw.Flush();
            sw.Close();

        }
    }
}
