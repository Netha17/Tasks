using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsTask
{
    internal class Student
    {
        public string studentName;
        public int admissionNo;
        public float marks;
        public static string collegeName;
        public Student()
        { }
        public Student(string name,int admitNo,float marks, string clgName)
        {
            studentName=name;
            admissionNo = admitNo;
            this.marks= marks;
            collegeName=clgName;

        }
        
    }
    class StudentFunction:Student
    {
        public StudentFunction() 
        { 
        }
        private Student student;
        public StudentFunction(Student s)
        {
            student = s;

        }
        public string GetStudentName()
        {
            return student.studentName;
        }
        public int GetAdmissionNo()
        {
            return student.admissionNo;
        }
        public float GetMarks()
        {
            return student.marks;
        }
        public  string GetCollegeName()
        {
            return Student.collegeName;
        }
    }
}
