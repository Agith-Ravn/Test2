using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Practice7.Models;

namespace Practice7.Controllers
{
    public class PeopleController : ApiController
    {
        private List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Agith", LastName = "Ravn", Id = 1 });
            people.Add(new Person { FirstName = "Ida", LastName = "Eriksøn", Id = 2 });
            people.Add(new Person { FirstName = "Kayla", LastName = "Kjæledyr", Id = 3 });
        }

        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            //Burde sjekke om det er gyldig verdi, men ikke så viktig nå..
            people.Add(val);
        }


        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
