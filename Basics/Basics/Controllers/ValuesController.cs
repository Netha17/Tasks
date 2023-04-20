using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Basics.Models;

namespace Basics.Controllers
{
    public class ValuesController : ApiController
    {
       static  List<Student> students = new List<Student>()
        {
            new Student(){Id=1,Name="nithin",marks=90},
            new Student(){Id=2,Name="Kamal",marks=95},
            new Student(){Id=3,Name="Rahul",marks=97}
        };
        // GET api/values
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/values/5
        public Student Get(int id)
        {
            return students[id - 1];
        }

        // POST api/values
        public void Post([FromBody] Student student)
        {
            students.Add(student);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Student student)
        {
           // students.FirstOrDefault(x=>x.Id== id).Name = student.Name;
            Student stud = students[id-1];
            stud.Name = student.Name;
            stud.marks = student.marks;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            int n=students.Count;
            students.RemoveAt(id);
        }
    }
}
