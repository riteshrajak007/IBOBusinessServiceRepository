using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Services
{
    public class ProgramService : IProgramService
    {
        private IUnitOfWork _unitOfWork;
        public ProgramService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddProgram(Program program)
        {
            //_unitOfWork.pr
            throw new NotImplementedException();
        }

        public void DeleteProgram(Program program)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Program> GetAllPrograms()
        {
            throw new NotImplementedException();
        }

        public Program GetProgram(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgram(int id, Program program)
        {
            throw new NotImplementedException();
        }
    }
}
