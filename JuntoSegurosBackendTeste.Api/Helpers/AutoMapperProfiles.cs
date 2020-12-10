using AutoMapper;
using JuntoSegurosBackendTeste.Api.Dtos;
using JuntoSegurosBackendTeste.Domain.Entities;

namespace JuntoSegurosBackendTeste.Api.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
        }
    }
}