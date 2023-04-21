using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SameOrigin.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<Country> countryList = new List<Country>()
        {
            new Country(){id=1,Name="Inda"},
            new Country(){id=2,Name="Srinlanka"},
            new Country(){id=3,Name="Nepal"},
            new Country(){id=4,Name="Pakistan"}
        };
        /// <summary>
        /// Get the countries list
        /// </summary>
        /// <remarks>Get the countries</remarks>
        /// <returns>List</returns>
        // GET api/values
        public IEnumerable<Country> Get()
        {
            return countryList;
        }

        /// <summary>
        /// Gets the country using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        public Country Get(int id)
        {
            return countryList[id];
        }
        /// <summary>
        /// Creates the new country entity
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Updates the country details using Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }
        /// <summary>
        /// Deletes the country using  Id
        /// </summary>
        /// <param name="id"></param>

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
