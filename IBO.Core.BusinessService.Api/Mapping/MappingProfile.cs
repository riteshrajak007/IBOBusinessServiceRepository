using AutoMapper;
using IBO.Core.BusinessService.Api.Resources;
using IBO.Core.BusinessService.Domain.Models;

namespace IBO.Core.BusinessService.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>()
    .ForMember(student => student.Id, opt => opt.Ignore());

            CreateMap<School, SchoolDto>();
            CreateMap<SchoolDto, School>()
    .ForMember(student => student.Id, opt => opt.Ignore());

        }
    }


}
