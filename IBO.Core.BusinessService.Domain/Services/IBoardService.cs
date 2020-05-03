using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IBoardService
    {
        Task<ICollection<Board>> GetAllBoardAsync();

        Task<Board> GetBoardAsync(int id);

        Task<ICollection<Board>> GetAllBoardByIdAsync(int id);

        Task<Board> UpdateBoardAsync(Board t, int key);

        Task<Board> AddBoardAsync(Board t);

        Task<int> DeleteBoardAsync(int id);
    }
}
