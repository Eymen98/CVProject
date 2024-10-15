using CVProject.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;

        public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }
        public IActionResult Index()
        {
            var results= _personRepository.GetAll();
            return View();
        }
    }
}
