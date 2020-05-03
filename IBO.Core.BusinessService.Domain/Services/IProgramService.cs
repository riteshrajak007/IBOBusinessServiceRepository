using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IProgramService
    {
        Task<ICollection<Program>> GetAllProgramAsync();

        Task<Program> GetProgramAsync(int id);

        Task<ICollection<Program>> GetAllProgramByIdAsync(int id);

        Task<Program> UpdateProgramAsync(Program t, int key);

        Task<Program> AddProgramAsync(Program t);

        Task<int> DeleteProgramAsync(int id);
    }
}
