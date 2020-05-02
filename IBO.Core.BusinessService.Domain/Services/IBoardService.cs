using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IBoardService
    {
        IEnumerable<Board> GetAllBoards();

        Board GetBoard(int id);

        void AddBoard(Board Board);

        void UpdateBoard(int id, Board Board);

        void DeleteBoard(Board Board);
    }
}
