using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AngularJs.Controllers
{

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    

    
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Person> Get()
        {

            var people = new List<Person>
            {
                new Person { ID=1, Name="Julius Bacosa", Age=32 },
                new Person { ID=2, Name="Anakin Skywalker", Age=25 },
                new Person { ID=3, Name="Obiwan Kinobi", Age=28 }
            };


            return people.ToList();
        }

        



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
