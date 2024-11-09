using AutoMapper;
using CVProject.Core.DTOs;
using CVProject.Core.Entities;

namespace CVProject.Core.Helper
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<Person, PersonDto>();
            
            CreateMap<Experience, ExperienceDto>();

            CreateMap<Education, EducationDto>();

            CreateMap<Project, ProjectDto>();

            CreateMap<Skill, SkillDto>();

            CreateMap<Language, LanguageDto>();
        }
    }
}
