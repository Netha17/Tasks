using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<Country> listCountries = new List<Country>()
        {
            new Country(){Id=1,Name="India"},
            new Country(){Id=2,Name="Srinlanka"}
        };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return listCountries;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Country Get(int id)
        {
            return listCountries[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
