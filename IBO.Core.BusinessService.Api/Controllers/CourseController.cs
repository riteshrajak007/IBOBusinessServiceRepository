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
using Microsoft.EntityFrameworkCore;

namespace IBO.Core.BusinessService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCourse()
        {
            var courses = _courseService.GetAllCourses().ToList();
            List<CourseDto> courseDtos = _mapper.Map<List<Course>, List<CourseDto>>(courses);
            return Ok(courseDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _courseService.GetCourse(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CourseDto>(course));
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] CourseDto coursedto)
        {
            if (coursedto == null)
            {
                return BadRequest();
            }
            try
            {
                _courseService.AddCourse(_mapper.Map<Course>(coursedto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, [FromBody] CourseDto coursedto)
        {
            if (id != coursedto.Id || coursedto == null)
            {
                return BadRequest();
            }
            try
            {
                _courseService.UpdateCourse(id, _mapper.Map<Course>(coursedto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            Course toBeDeletedItem = _courseService.GetCourse(id);
            if (toBeDeletedItem == null)
            {
                return NotFound();
            }
            _courseService.DeleteCourse(toBeDeletedItem);

            return Ok();
        }
    }
}