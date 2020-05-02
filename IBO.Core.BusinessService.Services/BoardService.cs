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
        public void AddBoard(Board Board)
        {
            throw new NotImplementedException();
        }

        public void DeleteBoard(Board Board)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Board> GetAllBoards()
        {
            throw new NotImplementedException();
        }

        public Board GetBoard(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBoard(int id, Board Board)
        {
            throw new NotImplementedException();
        }
    }
}
