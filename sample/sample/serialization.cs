using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sample
{
    internal class serialization
    {
        public static void Main(string[] args)

        {
            //BinaryFormatter bf = new BinaryFormatter();
            //using(FileStream fs=new FileStream("C:\\Practice\\Demo.txt", FileMode.OpenOrCreate))
            //{
            //    Student s = new Student(5, "ammu", "vjit");
            //    bf.Serialize(fs, s);

            //}
            //using(FileStream fs=new FileStream("C:\\Practice\\Demo.txt",FileMode.Open))
            //{
            //    Student students= (Student)bf.Deserialize(fs);
            //        Console.WriteLine(students.ToString());
            //}
            Student s1 = new Student();
            s1.id = 5;
            s1.name = "nithin";
            s1.clg = "vjit";
            Serialization(s1);
                

            Console.ReadLine();


                      
        }
        public static void Serialization(Student s)
        {
              XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (FileStream fs = new FileStream("C:\\Practice\\Demo.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, s);

            }

        }
            
    }
    [Serializable]
    public class Student
    {
        public int id;
        public string name;
       public  string clg;
        //public Student(int id, string name, string clg)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.clg = clg;
        //}
        public override string ToString()
        {
            return  this.id+" "+this.name+" "+this.clg;
        }
    }
}
