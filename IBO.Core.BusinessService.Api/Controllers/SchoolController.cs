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
    public class SchoolController : ControllerBase
    {
        private ISchoolService _schoolService;
        private readonly IMapper _mapper;

        public SchoolController(ISchoolService schoolService, IMapper mapper)
        {
            _schoolService = schoolService;
            _mapper = mapper;
        }

        /// <summary>
        /// GetAllSchool
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ICollection<SchoolDto>> GetAllSchoolAsync()
        {
            var schoolCollection = await _schoolService.GetAllSchoolAsync();
            return await Task.FromResult<ICollection<SchoolDto>>(_mapper.Map<ICollection<School>, ICollection<SchoolDto>>(schoolCollection));
        }


        /// <summary>
        /// GetSchool by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSchoolById/{id}")]
        public async Task<SchoolDto> GetSchoolAsync(int id)
        {
            var school = await _schoolService.GetSchoolAsync(id);
            return await Task.FromResult<SchoolDto>(_mapper.Map<SchoolDto>(school));
        }

        /// <summary>
        /// Add New School
        /// </summary>
        /// <param name="schooldto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddSchoolAsync([FromBody] SchoolDto schooldto)
        {
            if (schooldto == null) { return BadRequest(); }
            try
            {
                var school = _mapper.Map<School>(schooldto);
                await _schoolService.AddSchoolAsync(school);
            }
            catch(Exception ex)
            { return BadRequest(ex.Message); }

            return Ok();
        }

        /// <summary>
        /// Update School
        /// </summary>
        /// <param name="schooldto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> UpdateSchoolAsync([FromBody] SchoolDto schooldto)
        {
            if (schooldto == null) { return BadRequest(); }
            try
            {
                int key = schooldto.Id;
                School school = _mapper.Map<School>(schooldto);
                await _schoolService.UpdateSchoolAsync(school, key); 
            }
            catch(Exception ex)
            { return BadRequest(ex.Message); }

            return Ok();
        }
        
        /// <summary>
        /// Delete School
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteSchoolById/{id}")]
        public async Task<ActionResult> DeleteSchoolAsync(int id)
        {
            try
            { await _schoolService.DeleteSchoolAsync(id); }
            catch
            { return BadRequest(); }

            return Ok();
        }
    }
}