using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        List<StudentAttendance> studentAttendanceList = new List<StudentAttendance>() {
            new StudentAttendance()
            {
                StudentID= 1,
                StudentName="Nithin",
                AttendencePercentage= 75.5
            },
             new StudentAttendance()
            {
                StudentID= 2,
                StudentName="Kamal",
                AttendencePercentage= 92.5
            }
        };
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendance> Get()
        {
            return studentAttendanceList;
        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public StudentAttendance Get(int id)
        {
            return studentAttendanceList[id];
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
