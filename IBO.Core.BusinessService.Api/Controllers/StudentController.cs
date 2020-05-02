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
        }

        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var students = _studentService.GetAllStudents().ToList();
            List<StudentDto> studentDtos = _mapper.Map<List<Student>, List<StudentDto>>(students);
            return Ok(studentDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<StudentDto>(student));
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentDto studentdto)
        {
            if (studentdto == null)
            {
                return BadRequest();
            }
            try
            {
                _studentService.AddStudent(_mapper.Map<Student>(studentdto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentDto studentdto)
        {
            if (id != studentdto.Id || studentdto == null)
            {
                return BadRequest();
            }
            try
            {
                _studentService.UpdateStudent(id, _mapper.Map<Student>(studentdto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student toBeDeletedItem = _studentService.GetStudent(id);
            if (toBeDeletedItem == null)
            {
                return NotFound();
            }
            _studentService.DeleteStudent(toBeDeletedItem);

            return Ok();
        }

    }
}