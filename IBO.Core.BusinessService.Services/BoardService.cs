using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Services
{
    public class BoardService : IBoardService
    {
        private IUnitOfWork _unitOfWork;
        public BoardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddBoard(Board board)
        {
            _unitOfWork.Boards.Add(board);
            _unitOfWork.Complete();
            throw new NotImplementedException();
        }

        public void DeleteBoard(Board board)
        {
            _unitOfWork.Boards.Remove(board);
            _unitOfWork.Complete();
        }

        public IEnumerable<Board> GetAllBoards()
        {
            return _unitOfWork.Boards.GetAll();
        }

        public Board GetBoard(int id)
        {
            return _unitOfWork.Boards.Get(id);
        }

        public void UpdateBoard(int id, Board board)
        {
            _unitOfWork.Boards.Update(board);
            _unitOfWork.Complete();
        }
    }
}
