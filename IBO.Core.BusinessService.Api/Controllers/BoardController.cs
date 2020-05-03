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
    public class BoardController : ControllerBase
    {
        private IBoardService _boardService;
        private readonly IMapper _mapper;

        public BoardController(IBoardService boardService, IMapper mapper)
        {
            _boardService = boardService;
            _mapper = mapper;
        }

        //[HttpGet]
        //public IActionResult GetAllBoard()
        //{
        //    var boards = _boardService.GetAllBoards().ToList();
        //    List<BoardDto> boardDtos = _mapper.Map<List<Board>, List<BoardDto>>(boards);
        //    return Ok(boardDtos);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetBoard(int id)
        //{
        //    var board = _boardService.GetBoard(id);
        //    if (board == null) { return NotFound(); }
        //    return Ok(_mapper.Map<BoardDto>(board));
        //}

        //[HttpPost]
        //public IActionResult AddBoard([FromBody] BoardDto boarddto)
        //{
        //    if (boarddto == null)
        //    { return BadRequest();}
        //    try
        //    {
        //        _boardService.AddBoard(_mapper.Map<Board>(boarddto));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Ok();
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateBoard(int id, [FromBody] BoardDto boarddto)
        //{
        //    if (id != boarddto.Id || boarddto == null) { return BadRequest(); }
        //    try
        //    {
        //        _boardService.UpdateBoard(id, _mapper.Map<Board>(boarddto));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    return Ok();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteBoard(int id)
        //{
        //    Board toBeDeletedItem = _boardService.GetBoard(id);
        //    if (toBeDeletedItem == null) { return NotFound(); }
        //    _boardService.DeleteBoard(toBeDeletedItem);

        //    return Ok();
        //}
    }
}