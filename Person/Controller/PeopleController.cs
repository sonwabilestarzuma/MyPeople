using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThePerson.Models;

namespace ThePerson.Controller
{
    [Route("api/[Controller]")]
    public class PeopleController : ControllerBase
    {
        private People _people;

        public PeopleController(People people)
        {
            _people = people;
        }
        // Get api/people
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_people.Get());
        }
        //Get api/people/3
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_people.Get().Where(p => p.Id == id).FirstOrDefault());
        }
        //Post api/people
        [HttpPost]
        public IActionResult Post([FromBody]Person value)
        {
            if (string.IsNullOrWhiteSpace(value.Name))
            {
                return BadRequest("Name cannot be empty");
            }
            value.Id = _people.Get().Max(p => p.Id) + 1;
            _people.Add(value);

            return Created($"/api/people/{value.Id}", value);
        }
        // PUT api/people/3
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Person value)
        {
            var p = _people.Get().Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                p.Name = value.Name;
                p.Birthday = value.Birthday;
                p.Present = value.Present;
            }
            return Ok(p);
        }

        // DELETE api/people/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var p = _people.Get().Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                _people.Remove(p);
            }
            return Ok();
        }
    }
}