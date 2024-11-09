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
        private readonly IPersonEducationRepository _personEducationRepository;
        private readonly IPersonProjectRepository _personProjectRepository;
        private readonly IMapper _mapper;
        public PersonDetailsController(ILogger<PersonDetailsController> logger, IMapper mapper, IPersonExperienceRepository personExperienceRepository, IPersonEducationRepository personEducationRepository, IPersonProjectRepository personProjectRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _personExperienceRepository = personExperienceRepository;
            _personEducationRepository = personEducationRepository;
            _personProjectRepository = personProjectRepository;
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

        [HttpGet("getpersoneducation")]
        public List<EducationDto> GetPersonEducation(int userId)
        {
            var educationDtos = new List<EducationDto>();
            try
            {
                var educationList=_personEducationRepository.Find(x=>x.PersonId == userId);
                foreach(var educ in educationList)
                {
                    if (educationList != null)
                    {
                        var educationDto = _mapper.Map<EducationDto>(educ);
                        educationDtos.Add(educationDto);
                    }
                }   
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return educationDtos;
        }

        [HttpGet("getpersonproject")]
        public List<ProjectDto> GetPersonProject(int userId)
        {
            var projectDtos = new List<ProjectDto>();
            try
            {
                var projectList= _personProjectRepository.Find(x=>x.PersonId==userId);
                foreach (var project in projectList)
                {
                    var projectDto = _mapper.Map<ProjectDto>(project);
                    projectDtos.Add(projectDto);
                }

            }
            catch (Exception ex)
            {

                _logger.LogError(ex.ToString());
            }
            return projectDtos;
        }

    }
}
