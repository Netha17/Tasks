﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class LateBinding
    {
        public static void Main()
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            // To find the type of the Class Student
            Type studentType = executing.GetType("Reflections.Student");
            Console.WriteLine(studentType.FullName);

            // Create an Instance of the Student type
            object studentObject = Activator.CreateInstance(studentType);

            // Store the info of the method in an object
            // of class MethodInfo
            MethodInfo getMethod = studentType.GetMethod("GetDetails");
            
            // To store the parameters required
            // by Method GetDetails
            String[] param = new String[2];
            param[0] = "1";
            param[1] = "Lisa";

            // To display the result of the method
            String det = (String)getMethod.Invoke(studentObject, param);
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Roll Number - Name \n{0}", det);

        } // end Main

    } // end Program

}
    

