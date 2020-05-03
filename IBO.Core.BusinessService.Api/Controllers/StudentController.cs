using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IBO.Core.BusinessService.Domain.Services;
using IBO.Core.BusinessService.Api.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IBO.Core.BusinessService.Domain.Models;

namespace IBO.Core.BusinessService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [Route("~/api/Student")]
        [HttpGet]
        public async Task<ICollection<Student>> GetAllStudentAsync()
        {
            return await _studentService.GetAllStudentAsync();
        }


        [HttpGet("{id}")]
        public async Task<Student> GetStudentAsync(int id)
        {
            return await _studentService.GetStudentAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> AddStudentAsync([FromBody] StudentDto studentdto)
        {
            if (studentdto == null) { return BadRequest(); }
            try
            { await _studentService.AddStudentAsync(_mapper.Map<Student>(studentdto)); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateStudentAsync(int id, [FromBody] StudentDto studentdto)
        {
            if (studentdto == null) { return BadRequest(); }
            try
            { await _studentService.UpdateStudentAsync(_mapper.Map<Student>(studentdto), id); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudentAsync(int id)
        {
            try
            { await _studentService.DeleteStudentAsync(id); }
            catch
            { return BadRequest(); }

            return Ok();
        }

    }
}