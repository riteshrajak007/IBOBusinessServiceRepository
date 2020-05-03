using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface ISchoolService
    {
        Task<ICollection<School>> GetAllSchoolAsync();

        Task<School> GetSchoolAsync(int id);

        Task<ICollection<School>> GetAllSchoolByIdAsync(int id);

        Task<School> UpdateSchoolAsync(School t, int key);

        Task<School> AddSchoolAsync(School t);

        Task<int> DeleteSchoolAsync(int id);

    }
}
