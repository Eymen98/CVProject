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
        }
    }
}
