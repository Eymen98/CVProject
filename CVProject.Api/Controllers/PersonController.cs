using AutoMapper;
using CVProject.Core.DTOs;
using CVProject.Core.Entities;
using CVProject.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository, IMapper mapper)
        {
            _logger = logger;
            _personRepository = personRepository;
            _mapper = mapper;
        }

        [HttpGet("getpersoninformations")]
        public PersonDto GetPersonInformations(int userId)
        {
            try
            {
                var personEntity = _personRepository.FindOne(x => x.Id == userId);
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
