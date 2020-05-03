using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IBO.Core.BusinessService.Api.Resources;
using IBO.Core.BusinessService.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IBO.Core.BusinessService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        private IProgramService _programService;
        private readonly IMapper _mapper;

        public ProgramController(IProgramService programService, IMapper mapper)
        {
            _programService = programService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ICollection<IBO.Core.BusinessService.Domain.Models.Program>> GetAllProgramAsync()
        {
            return await _programService.GetAllProgramAsync();
        }


        [HttpGet("{id}")]
        public async Task<IBO.Core.BusinessService.Domain.Models.Program> GetProgramAsync(int id)
        {
            return await _programService.GetProgramAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> AddProgramAsync([FromBody] ProgramDto programdto)
        {
            if (programdto == null) { return BadRequest(); }
            try
            { await _programService.AddProgramAsync(_mapper.Map<IBO.Core.BusinessService.Domain.Models.Program>(programdto)); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProgramAsync(int id, [FromBody] ProgramDto programdto)
        {
            if (programdto == null) { return BadRequest(); }
            try
            { await _programService.UpdateProgramAsync(_mapper.Map<IBO.Core.BusinessService.Domain.Models.Program>(programdto), id); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProgramAsync(int id)
        {
            try
            { await _programService.DeleteProgramAsync(id); }
            catch
            { return BadRequest(); }

            return Ok();
        }
    }
}