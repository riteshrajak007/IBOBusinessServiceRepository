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

        Board AddBoard(Board student);

        void UpdateBoard(Board student);
    }
}
