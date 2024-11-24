using AutoMapper;
using CVProject.Core.Attributes;
using CVProject.Core.DTOs;
using CVProject.Core.Entities;
using CVProject.Core.Interfaces.Repository;
using CVProject.Infrastructure.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CVProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [BasicAuth]
    public class PersonDetailsController : ControllerBase
    {
        private readonly ILogger<PersonDetailsController> _logger;
        private readonly IMapper _mapper;
        private readonly IPersonExperienceRepository _personExperienceRepository;
        private readonly IPersonEducationRepository _personEducationRepository;
        private readonly IPersonProjectRepository _personProjectRepository;
        private readonly IPersonSkillRepository _personSkillRepository;
        private readonly IPersonLanguageRepository _personLanguageRepository;
        private readonly IConfiguration _configuration;


        public PersonDetailsController(ILogger<PersonDetailsController> logger, IMapper mapper, IPersonExperienceRepository personExperienceRepository, IPersonEducationRepository personEducationRepository, IPersonProjectRepository personProjectRepository, IPersonSkillRepository personSkillRepository, IPersonLanguageRepository personLanguageRepository, IConfiguration configuration)
        {
            _logger = logger;
            _mapper = mapper;
            _personExperienceRepository = personExperienceRepository;
            _personEducationRepository = personEducationRepository;
            _personProjectRepository = personProjectRepository;
            _personSkillRepository = personSkillRepository;
            _personLanguageRepository = personLanguageRepository;
            _configuration = configuration;
        }

        [HttpGet("getpersonexperience")]
        public List<ExperienceDto> GetPersonExperience()
        {

            var experienceDtos = new List<ExperienceDto>();
            try
            {
                int uid = Convert.ToInt32(_configuration.GetValue<string>("UId"));
                var experienceList = _personExperienceRepository.Find(x=> x.PersonId == uid);
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
        public List<EducationDto> GetPersonEducation()
        {
            var educationDtos = new List<EducationDto>();
            try
            {
                int uid = Convert.ToInt32(_configuration.GetValue<string>("UId"));
                var educationList = _personEducationRepository.Find(x => x.PersonId == uid);
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
        public List<ProjectDto> GetPersonProject()
        {
            var projectDtos = new List<ProjectDto>();
            try
            {
                int uid = Convert.ToInt32(_configuration.GetValue<string>("UId"));
                var projectList = _personProjectRepository.Find(x => x.PersonId == uid);
                foreach (var project in projectList)
                {
                    if (projectList!=null)
                    {
                        var projectDto = _mapper.Map<ProjectDto>(project);
                        projectDtos.Add(projectDto);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return projectDtos;
        }

        [HttpGet("getpersonskill")]
        public List<SkillDto> GetPersonSkill()
        {
            var skillDtos = new List<SkillDto>();
            try
            {
                int uid = Convert.ToInt32(_configuration.GetValue<string>("UId"));
                var skillList = _personSkillRepository.Find(x => x.PersonId == uid);
                foreach (var skill in skillList)
                {
                    if (skillList!=null)
                    {
                        var skillDto= _mapper.Map<SkillDto>(skill);
                        skillDtos.Add(skillDto);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return skillDtos;
        }

        [HttpGet("getpersonlanguages")]
        public List<LanguageDto> GetPersonLanguages()
        {
            var languageDtos = new List<LanguageDto>();
            try
            {
                int uid = Convert.ToInt32(_configuration.GetValue<string>("UId"));
                var languageList = _personLanguageRepository.Find(x => x.PersonId == uid);
                foreach (var language in languageList)
                {
                    if (languageList!=null)
                    {
                        var languageDto = _mapper.Map<LanguageDto>(language);
                        languageDtos.Add(languageDto);
                    }
                }
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.ToString());
            }
            return languageDtos;
        }

    }
}
