using AutoMapper;
using IBO.Core.BusinessService.Api.Resources;
using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    .ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<Program, ProgramDto>();
            //CreateMap<ProgramDto, Program>();

            CreateMap<Course, CourseDto>();
            //CreateMap<CourseDto, Course>();

            CreateMap<Board, BoardDto>();
            //CreateMap<BoardDto, Board>();
        }
    }

    
}
