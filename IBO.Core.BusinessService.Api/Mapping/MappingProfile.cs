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
            CreateMap<School, SchoolDto>();
        }
    }
}
