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
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ICollection<Student>> GetAllStudentAsync()
        {
            return await _unitOfWork.Students.GetAllAsync();
        }
        public async Task<ICollection<Student>> GetAllStudentByIdAsync(int id)
        {
            return await _unitOfWork.Students.FindAllAsync(c => c.Id == id);
        }
        public async Task<Student> GetStudentAsync(int id)
        {
            return await _unitOfWork.Students.FindAsync(c => c.Id == id);
        }

        public async Task<Student> UpdateStudentAsync(Student t, int key)
        {
            return await _unitOfWork.Students.UpdateAsync(t, key);
        }

        public async Task<Student> AddStudentAsync(Student t)
        {
            return await _unitOfWork.Students.AddAsync(t);
        }

        public async Task<int> DeleteStudentAsync(int id)
        {
            Student itemStudent = _unitOfWork.Students.Find(c => c.Id == id);
            return await _unitOfWork.Students.DeleteAsync(itemStudent);
        }
    }
}
