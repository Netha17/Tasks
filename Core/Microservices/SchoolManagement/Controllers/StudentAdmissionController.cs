using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        List<StudentAdmission> studentAdmissionList = new List<StudentAdmission>() {
                new StudentAdmission(){StudentID= 1,StudentName="Nithin",StudentClass="X",DateofJoining=DateTime.Now},
                new StudentAdmission(){StudentID=2,StudentName="Kamal",StudentClass="IX",DateofJoining=DateTime.Now}


        };
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmission> Get()
        {
            return studentAdmissionList;
        }

        // GET api/<StudentAdmissionController>/5
        [HttpGet("{id}")]
        public StudentAdmission Get(int id)
        {
            return studentAdmissionList[id];
        }

        // POST api/<StudentAdmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
