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
        
        
        public async Task<ICollection<Course>> GetAllCourseAsync()
        {
            return await _courseService.GetAllCourseAsync();
        }


        [HttpGet("{id}")]
        
        
        public async Task<Course> GetCourseAsync(int id)
        {
            return await _courseService.GetCourseAsync(id);
        }

        [HttpPost]
        
        
        public async Task<ActionResult> AddCourseAsync([FromBody] CourseDto coursedto)
        {
            if (coursedto == null) { return BadRequest(); }
            try
            { await _courseService.AddCourseAsync(_mapper.Map<Course>(coursedto)); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpPut("{id}")]
        
        
        public async Task<ActionResult> UpdateCourseAsync(int id, [FromBody] CourseDto coursedto)
        {
            if (coursedto == null) { return BadRequest(); }
            try
            { await _courseService.UpdateCourseAsync(_mapper.Map<Course>(coursedto), id); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpDelete("{id}")]
        
        
        public async Task<ActionResult> DeleteCourseAsync(int id)
        {
            try
            { await _courseService.DeleteCourseAsync(id); }
            catch
            { return BadRequest(); }

            return Ok();
        }
    }
}