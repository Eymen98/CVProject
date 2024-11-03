using CVProject.Core.Entities;
using CVProject.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Web.Angular.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;

        public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }
        [HttpGet("GetPersonInformations")]
        public Person GetPersonInformations()
        {
            var person=_personRepository.FindOne(x=> x.Id == 1);
            return person;
        }
    }
}
