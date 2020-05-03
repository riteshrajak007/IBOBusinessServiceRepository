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

        //[Route("~/api/School")]
        [HttpGet]
        public async Task<ICollection<SchoolDto>> GetAllSchoolAsync()
        {
            var schoolCollection = await _schoolService.GetAllSchoolAsync();
            return await Task.FromResult<ICollection<SchoolDto>>(_mapper.Map<ICollection<School>, ICollection<SchoolDto>>(schoolCollection));
        }


        [HttpGet("{id}")]
        public async Task<SchoolDto> GetSchoolAsync(int id)
        {
            var school = await _schoolService.GetSchoolAsync(id);
            return await Task.FromResult<SchoolDto>(_mapper.Map<SchoolDto>(school));
        }

        [HttpPost]
        public async Task<ActionResult> AddSchoolAsync([FromBody] SchoolDto schooldto)
        {
            if (schooldto == null) { return BadRequest(); }
            try
            { await _schoolService.AddSchoolAsync(_mapper.Map<School>(schooldto)); }
            catch(Exception ex)
            { return BadRequest(ex.Message); }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSchoolAsync(int id, [FromBody] SchoolDto schooldto)
        {
            if (schooldto == null) { return BadRequest(); }
            try
            {
                School school = _mapper.Map<School>(schooldto);
                await _schoolService.UpdateSchoolAsync(school, id); 
            }
            catch(Exception ex)
            { return BadRequest(ex.Message); }

            return Ok();
        }

        [HttpDelete("{id}")]
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