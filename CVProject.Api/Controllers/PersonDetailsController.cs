using AutoMapper;
using CVProject.Core.DTOs;
using CVProject.Core.Interfaces.Repository;
using CVProject.Infrastructure.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class PersonDetailsController : ControllerBase
    {
        private readonly ILogger<PersonDetailsController> _logger;
        private readonly IPersonExperienceRepository _personExperienceRepository;
        private readonly IMapper _mapper;
        public PersonDetailsController(ILogger<PersonDetailsController> logger, IMapper mapper, IPersonExperienceRepository personExperienceRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _personExperienceRepository = personExperienceRepository;
        }

        [HttpGet("getpersonexperience")]
        public List<ExperienceDto> GetPersonExperience(int userId)
        {

            var experienceDtos = new List<ExperienceDto>();
            try
            {
                var experienceList = _personExperienceRepository.Find(x=> x.PersonId == userId);
                foreach (var experience in experienceList)
                {
                    if (experience!=null)
                    {
                        var experienceDto = _mapper.Map<ExperienceDto>(experience);
                        experienceDtos.Add(experienceDto);
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return experienceDtos;
        }

    }
}
