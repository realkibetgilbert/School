using AutoMapper;
using School.API.Dto.Students;
using School.MODEL;

namespace School.API.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentToCreateDto, Student>()
   .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.Now))
   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => "system"));
            CreateMap<Student, StudentToDisplayDto>();
        }
    }
}
