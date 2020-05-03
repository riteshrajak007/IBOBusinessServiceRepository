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

        [Route("~/api/School")]
        [HttpGet]
        public async Task<ICollection<School>> GetAllSchoolAsync()
        {
            return await _schoolService.GetAllSchoolAsync();
        }


        [HttpGet("{id}")]
        public async Task<School> GetSchoolAsync(int id)
        {
            return await _schoolService.GetSchoolAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> AddSchoolAsync([FromBody] SchoolDto schooldto)
        {
            if (schooldto == null) { return BadRequest(); }
            try
            { await _schoolService.AddSchoolAsync(_mapper.Map<School>(schooldto)); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSchoolAsync(int id, [FromBody] SchoolDto schooldto)
        {
            if (schooldto == null) { return BadRequest(); }
            try
            { await _schoolService.UpdateSchoolAsync(_mapper.Map<School>(schooldto), id); }
            catch
            { return BadRequest(); }

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