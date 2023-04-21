using System.Collections.Generic;
using System.Linq;

namespace MVCDemo.Models
{
    public class TestStudentRepository : IStudentRepository
    {
        public static List<Student> studentsList = new List<Student>()
        {
                new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
                new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
                new Student() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
        };

        public void AddStudent(Student s)
        {
            studentsList.Add(s);
        }

        public Student GetStudent(int id)
        {
            return studentsList.FirstOrDefault(e => e.StudentId == id);
        }
    }
}
