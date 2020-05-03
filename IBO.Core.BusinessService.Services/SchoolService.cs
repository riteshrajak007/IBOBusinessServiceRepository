using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Services
{
    public class SchoolService : ISchoolService
    {
        private  IUnitOfWork _unitOfWork;
        public SchoolService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ICollection<School>> GetAllSchoolAsync()
        {
            IQueryable<School> schoolList = _unitOfWork.Schools.GetAllIncluding(u => u.Language, u => u.Students, u => u.Board);
            return await _unitOfWork.Schools.GetAllAsync();
        }
        public async Task<ICollection<School>> GetAllSchoolByIdAsync(int id)
        {
            return await _unitOfWork.Schools.FindAllAsync(c => c.Id == id);
        }
        public async Task<School> GetSchoolAsync(int id)
        {
            return await _unitOfWork.Schools.FindAsync(c => c.Id == id);
        }

        public async Task<School> UpdateSchoolAsync(School t, int key)
        {
            return await _unitOfWork.Schools.UpdateAsync(t, key);
        }

        public async Task<School> AddSchoolAsync(School t)
        {
            return await _unitOfWork.Schools.AddAsync(t);
        }

        public async Task<int> DeleteSchoolAsync(int id)
        {
            School itemSchool =_unitOfWork.Schools.Find(c => c.Id == id);
            return await _unitOfWork.Schools.DeleteAsync(itemSchool);
        }

    }
}
