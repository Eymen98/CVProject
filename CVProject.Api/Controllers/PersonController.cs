using Microsoft.AspNetCore.Mvc;

namespace CVProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getpersoninformations")]
        public string GetPersonInformations()
        {
            try
            {
                var  

            }
            catch (Exception ex )
            {

            _logger.LogError(ex.ToString());
            }
        }



    }
}
