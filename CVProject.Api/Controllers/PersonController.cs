using AutoMapper;
using CVProject.Core.Attributes;
using CVProject.Core.DTOs;
using CVProject.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [BasicAuth]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository, IMapper mapper, IConfiguration configuration)
        {
            _logger = logger;
            _personRepository = personRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("getpersoninformations")]
        public PersonDto GetPersonInformations()
        {
            try
            {
                int uid = Convert.ToInt32(_configuration.GetValue<string>("UId"));

                var personEntity = _personRepository.FindOne(x => x.Id == uid);
                
                if (personEntity != null)
                {
                    var personDto = _mapper.Map<PersonDto>(personEntity);
                    return personDto;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return new PersonDto();
        }
    }
}
