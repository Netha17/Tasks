using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get the current assembly
            Assembly executing=Assembly.GetExecutingAssembly(); 

            //Get the type object
            Type studentType=executing.GetType("ReflectionsTask.StudentFunction"); 

            
         
            //create instance of the type
            dynamic studObj=Activator.CreateInstance(studentType);

            //Get the type of the class
            Type classType = studObj.GetType();

            //To get all the public fields/variables
            Console.WriteLine("PUBLIC FIELDS");
            foreach(MemberInfo member in classType.GetFields()) 
            {
                Console.WriteLine(member.Name);

            }
            //To get the all public methods
            Console.WriteLine("PUBLIC METHODS");
            foreach(MemberInfo method in classType.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            //To get the all public constructors
            Console.WriteLine("PUBLIC CONSTRUCTORS");
            foreach (MemberInfo constructor in classType.GetConstructors())
            {
                Console.WriteLine(constructor.Name);
                
            }


            Console.ReadLine();
        }
    }
}
