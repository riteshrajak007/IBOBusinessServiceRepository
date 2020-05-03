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

        [Route("~/api/Board")]
        [HttpGet]
        public async Task<ICollection<Board>> GetAllBoardAsync()
        {
            return await _boardService.GetAllBoardAsync();
        }

        [HttpGet("{id}")]
        public async Task<Board> GetBoardAsync(int id)
        {
            return await _boardService.GetBoardAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> AddBoardAsync([FromBody] BoardDto boarddto)
        {
            if (boarddto == null) { return BadRequest(); }
            try
            { await _boardService.AddBoardAsync(_mapper.Map<Board>(boarddto)); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBoardAsync(int id, [FromBody] BoardDto boarddto)
        {
            if (boarddto == null) { return BadRequest(); }
            try
            { await _boardService.UpdateBoardAsync(_mapper.Map<Board>(boarddto), id); }
            catch
            { return BadRequest(); }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBoardAsync(int id)
        {
            try
            { await _boardService.DeleteBoardAsync(id); }
            catch
            { return BadRequest(); }

            return Ok();
        }
    }
}