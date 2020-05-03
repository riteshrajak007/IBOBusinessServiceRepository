using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IBO.Core.BusinessService.Services
{
    public class SchoolService : ISchoolService
    {
        private IUnitOfWork _unitOfWork;
        public SchoolService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ICollection<School>> GetAllSchoolAsync()
        {
            return await Task.FromResult<ICollection<School>>(_unitOfWork.Schools.GetAllIncluding(u => u.Language, u => u.Board).ToList());
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
            try
            {
                return await _unitOfWork.Schools.UpdateAsync(t,(object)key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<School> AddSchoolAsync(School t)
        {
            try
            {
                return await _unitOfWork.Schools.AddAsync(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteSchoolAsync(int id)
        {
            School itemSchool = _unitOfWork.Schools.Find(c => c.Id == id);
            return await _unitOfWork.Schools.DeleteAsync(itemSchool);
        }

    }
}
