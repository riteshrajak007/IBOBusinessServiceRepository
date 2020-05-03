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
    public class ProgramService : IProgramService
    {
        private IUnitOfWork _unitOfWork;
        public ProgramService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ICollection<Program>> GetAllProgramAsync()
        {
            return await _unitOfWork.Programs.GetAllAsync();
        }
        public async Task<ICollection<Program>> GetAllProgramByIdAsync(int id)
        {
            return await _unitOfWork.Programs.FindAllAsync(c => c.Id == id);
        }
        public async Task<Program> GetProgramAsync(int id)
        {
            return await _unitOfWork.Programs.FindAsync(c => c.Id == id);
        }

        public async Task<Program> UpdateProgramAsync(Program t, int key)
        {
            return await _unitOfWork.Programs.UpdateAsync(t, key);
        }

        public async Task<Program> AddProgramAsync(Program t)
        {
            return await _unitOfWork.Programs.AddAsync(t);
        }

        public async Task<int> DeleteProgramAsync(int id)
        {
            Program itemProgram = _unitOfWork.Programs.Find(c => c.Id == id);
            return await _unitOfWork.Programs.DeleteAsync(itemProgram);
        }
    }
}
