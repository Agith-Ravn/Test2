using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Øvelse4.Model;

namespace Øvelse4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public Person GetOne(int id)
        {
            return new Person()
            {
                Id = id,
                Email = "test@epost.net",
                Name = "Test"
            };
        }

        public IEnumerable<Person> GetMany()
        {

        }
    }
}
