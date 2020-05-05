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

        /// <summary>
        /// Fetch All Students by Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ICollection<Student>> GetAllStudentAsync()
        {
            return await _studentService.GetAllStudentAsync();
        }


        /// <summary>
        /// Fetch Students by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public async Task<Student> GetStudentAsync(int id)
        {
            return await _studentService.GetStudentAsync(id);
        }


        /// <summary>
        /// Add Students in Db
        /// </summary>
        /// <param name="studentdto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddStudentAsync([FromBody] StudentDto studentdto)
        {
            if (studentdto == null) { return BadRequest(); }
            try
            {
                var school = _mapper.Map<Student>(studentdto);
                await _studentService.AddStudentAsync(school);
            }
            catch
            { return BadRequest(); }

            return Ok();
        }

        /// <summary>
        /// Update Students in Db
        /// </summary>
        /// <param name="studentdto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> UpdateStudentAsync([FromBody] StudentDto studentdto)
        {
            if (studentdto == null) { return BadRequest(); }
            try
            {
                int key = studentdto.Id;
                var school = _mapper.Map<Student>(studentdto);
                await _studentService.UpdateStudentAsync(school, key); 
            }
            catch
            { return BadRequest(); }

            return Ok();
        }

        /// <summary>
        /// Deletes Student from tblStudent
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteStudentById/{id}")]
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