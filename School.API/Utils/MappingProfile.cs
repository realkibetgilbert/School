using AutoMapper;
using School.API.Dto.Hostel;
using School.API.Dto.Students;
using School.API.Dto.Units;
using School.MODEL;

namespace School.API.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //mapping students
            //s=>d
            CreateMap<StudentToCreateDto, Student>()
   .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.Now))
   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => "system")).ReverseMap();
            CreateMap<Student, StudentToDisplayDto>().ReverseMap();

            //mapping units
            //s=>d
            CreateMap<UnitToCreateDto, Unit>()
   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => "system"))
   .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.Now)).ReverseMap();
            // db=>ui
            CreateMap<Unit, UnitToDisplayDto>().ReverseMap();

            //mapping Hostels 
            //s=>d
            CreateMap<HostelToCreateDto, Hostel>()
  .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => "system"))
  .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.Now)).ReverseMap();

            //db=>ui
            CreateMap<UpdateHostelDto, Hostel>()
   .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.Now))
   .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => "system")).ReverseMap();
            CreateMap<Hostel, HostelToDisplayDto>().ReverseMap();


        }
    }
}
