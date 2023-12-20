using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using AutoMapper;

namespace assignment_1_webapi.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<SemesterModel, SemesterAddDto>().ReverseMap();
        }
    }
}