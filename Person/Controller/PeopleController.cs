using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Person.Models;

namespace Person.Controller
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
    }
}