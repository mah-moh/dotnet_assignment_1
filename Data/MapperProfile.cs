using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using AutoMapper;

namespace assignment_1_webapi.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<StudentModel, StudentDto>().ReverseMap();
            CreateMap<SemesterModel, SemesterAddDto>().ReverseMap();
        }
    }
}