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
    public class PersonController : ControllerBase
    {
        private Person[] _data = new[]
        {
            new Person() {Id = 1, Email = "test1@epost.net", Name = "Test1"},
            new Person() {Id = 2, Email = "test2@epost.net", Name = "Test2"}
        };

    [HttpGet("{id}")]
        public async Task<Person> GetOne(int id)
        {
            return await Task.Run(() => _data.SingleOrDefault(p => p.Id==id)

                //new Person()
                //{
                //    Id = id,
                //    Email = "test@epost.net",
                //    Name = "Test"
                //}
            );
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> GetMany()
        {
            return await Task.Run(() => _data);
        }

        [HttpPost]
        public async Task<int> Create(Person person)
        {
            return await Task.Run(() => 1);
        }

        [HttpPut]
        public async Task<int> Edit(Person person)
        {
            return await Task.Run(() => 1);
        }

        [HttpDelete]
        public async Task<int> Delete(int id)
        {
            return await Task.Run(() => 1);
        }
    }
}
