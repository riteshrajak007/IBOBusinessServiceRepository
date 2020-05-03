using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Services
{
    public class BoardService : IBoardService
    {
        private IUnitOfWork _unitOfWork;
        public BoardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ICollection<Board>> GetAllBoardAsync()
        {
            return await _unitOfWork.Boards.GetAllAsync();
        }
        public async Task<ICollection<Board>> GetAllBoardByIdAsync(int id)
        {
            return await _unitOfWork.Boards.FindAllAsync(c => c.Id == id);
        }
        public async Task<Board> GetBoardAsync(int id)
        {
            return await _unitOfWork.Boards.FindAsync(c => c.Id == id);
        }

        public async Task<Board> UpdateBoardAsync(Board t, int key)
        {
            return await _unitOfWork.Boards.UpdateAsync(t, key);
        }

        public async Task<Board> AddBoardAsync(Board t)
        {
            return await _unitOfWork.Boards.AddAsync(t);
        }

        public async Task<int> DeleteBoardAsync(int id)
        {
            Board itemBoard = _unitOfWork.Boards.Find(c => c.Id == id);
            return await _unitOfWork.Boards.DeleteAsync(itemBoard);
        }
    }
}
