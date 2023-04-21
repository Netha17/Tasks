using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqDemo
{
    public class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        static public List<Student> GetAllStudent()
        {
            List<Student> list = new List<Student>()
            {
                new Student { Id = 1, name = "nithin", age = 15 },
                new Student { Id = 2, name = "kamala", age = 18 },
                new Student { Id = 3, name = "Rahul", age = 19 }
            };
            return list;
        }
    }
}