using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SomeApi.Models;
using SomeApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {       
        private readonly ILogger<PersonsController> _logger;
        private readonly IPersonService _personService;

        public PersonsController(ILogger<PersonsController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personService.GetAll();
        }

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _personService.Get(id);
        }

        [HttpPost]
        public void Create(Person person)
        {
            _personService.Add(person);
        }

        [HttpPatch]
        public void Update(Person person)
        {
            _personService.Update(person);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _personService.Delete(id);
        }
    }
}