using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IProgramService
    {
        IEnumerable<Program> GetAllPrograms();

        Program GetProgram(int id);

        void AddProgram(Program program);

        void UpdateProgram(int id, Program program);

        void DeleteProgram(Program program);
    }
}
