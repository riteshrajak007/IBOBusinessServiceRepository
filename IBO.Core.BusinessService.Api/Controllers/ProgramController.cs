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
        //private IProgramService _programService;
        //private readonly IMapper _mapper;

        //public ProgramController(IProgramService programService, IMapper mapper)
        //{
        //    _programService = programService;
        //    _mapper = mapper;
        //}

        //[HttpGet]
        //public IActionResult GetAllProgram()
        //{
        //    var programs = _programService.GetAllPrograms().ToList();
        //    List<ProgramDto> programDtos = _mapper.Map<List<Program>, List<ProgramDto>>(programs);
        //    return Ok(programDtos);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetProgram(int id)
        //{
        //    var program = _programService.GetProgram(id);
        //    if (program == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(_mapper.Map<ProgramDto>(program));
        //}

        //[HttpPost]
        //public IActionResult AddProgram([FromBody] ProgramDto programdto)
        //{
        //    if (programdto == null)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        _programService.AddProgram(_mapper.Map<Program>(programdto));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Ok();
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateProgram(int id, [FromBody] ProgramDto programdto)
        //{
        //    if (id != programdto.Id || programdto == null)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        _programService.UpdateProgram(id, _mapper.Map<Program>(programdto));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Ok();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteProgram(int id)
        //{
        //    var toBeDeletedItem = _programService.GetProgram(id);
        //    if (toBeDeletedItem == null)
        //    {
        //        return NotFound();
        //    }
        //    _programService.DeleteProgram(toBeDeletedItem);

        //    return Ok();
        //}
    }
}