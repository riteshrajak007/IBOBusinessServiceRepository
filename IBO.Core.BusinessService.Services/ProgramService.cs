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
            _unitOfWork.Programs.Add(program);
            _unitOfWork.Complete();
            throw new NotImplementedException();
        }

        public void DeleteProgram(Program program)
        {
            _unitOfWork.Programs.Remove(program);
            _unitOfWork.Complete();
        }

        public IEnumerable<Program> GetAllPrograms()
        {
            return _unitOfWork.Programs.GetAll();
        }

        public Program GetProgram(int id)
        {
            return _unitOfWork.Programs.Get(id);
        }

        public void UpdateProgram(int id, Program program)
        {
            _unitOfWork.Programs.Update(program);
            _unitOfWork.Complete();
        }
    }
}
