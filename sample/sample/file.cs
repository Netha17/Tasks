using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using DemoLibrary;

namespace sample
{
    internal class file
    {
        public void WriteToFIle()
        { 
            StreamWriter sw = new StreamWriter("C://Practice//Demo.txt",true);
             
            Console.WriteLine("Enter the Text that you want to write on File");

           
            string str = Console.ReadLine();

           
            sw.WriteLine(str);

           
            sw.Flush();
 
            sw.Close();
        }
        public void ReadFromFile()
        {
            StreamReader sr = new StreamReader("C://Practice//Demo.txt");

            Console.WriteLine("Content of the File");

            
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            
            string str = sr.ReadToEnd();
            for(int i=str.Length; i>0; i--)
            {
                Console.Write(str[i-1] + "");
            }
             

            Console.ReadLine();

         
            sr.Close();
        }
        static void Main(string[] args)
        {
            
            file file = new file();
            file.WriteToFIle();
            file.ReadFromFile();
          
        }
    }

}
    

