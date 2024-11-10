﻿using AutoMapper;
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

        public PersonDetailsController(ILogger<PersonDetailsController> logger, IMapper mapper, IPersonExperienceRepository personExperienceRepository, IPersonEducationRepository personEducationRepository, IPersonProjectRepository personProjectRepository, IPersonSkillRepository personSkillRepository, IPersonLanguageRepository personLanguageRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _personExperienceRepository = personExperienceRepository;
            _personEducationRepository = personEducationRepository;
            _personProjectRepository = personProjectRepository;
            _personSkillRepository = personSkillRepository;
            _personLanguageRepository = personLanguageRepository;
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
        public List<SkillDto> GetPersonSkill(int userId)
        {
            var skillDtos = new List<SkillDto>();
            try
            {
                var skillList=_personSkillRepository.Find(x=>x.PersonId== userId);
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

        //[HttpGet("getpersonlanguage")]
        //public List<LanguageDto> GetPersonLanguage(int userId) 
        //{
        //    var languageDtos = new List<LanguageDto>();
        //    try
        //    {
        //        var languageList = _personLanguageRepository.Fİ
        //    }
        //    catch (Exception ex)
        //    {

        //        _logger.LogError(ex.ToString());
        //    }
        //    return languageDtos;
        //}

    }
}
