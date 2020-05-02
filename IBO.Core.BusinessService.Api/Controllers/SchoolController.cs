using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IBO.Core.BusinessService.Api.Resources;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IBO.Core.BusinessService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private ISchoolService _schoolService;
        private readonly IMapper _mapper;

        public SchoolController(ISchoolService schoolService, IMapper mapper)
        {
            _schoolService = schoolService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllSchool()
        {
            var schools = _schoolService.GetAllSchools().ToList();
            List<SchoolDto> schoolDtos = _mapper.Map<List<School>, List<SchoolDto>>(schools);
            return Ok(schoolDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetSchool(int id)
        {
            var school = _schoolService.GetSchool(id);
            if (school == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<SchoolDto>(school));
        }

        [HttpPost]
        public IActionResult AddSchool([FromBody] SchoolDto schooldto)
        {
            if (schooldto == null)
            {
                return BadRequest();
            }
            try
            {
                _schoolService.AddSchool(_mapper.Map<School>(schooldto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSchool([FromBody] SchoolDto schooldto)
        {
            if (schooldto == null)
            {
                return BadRequest();
            }
            try
            {
                _schoolService.UpdateSchool(_mapper.Map<School>(schooldto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}