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
    public class CourseService : ICourseService
    {
        private IUnitOfWork _unitOfWork;
        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ICollection<Course>> GetAllCourseAsync()
        {
            return await _unitOfWork.Courses.GetAllAsync();
        }
        public async Task<ICollection<Course>> GetAllCourseByIdAsync(int id)
        {
            return await _unitOfWork.Courses.FindAllAsync(c => c.Id == id);
        }
        public async Task<Course> GetCourseAsync(int id)
        {
            return await _unitOfWork.Courses.FindAsync(c => c.Id == id);
        }

        public async Task<Course> UpdateCourseAsync(Course t, int key)
        {
            return await _unitOfWork.Courses.UpdateAsync(t, key);
        }

        public async Task<Course> AddCourseAsync(Course t)
        {
            return await _unitOfWork.Courses.AddAsync(t);
        }

        public async Task<int> DeleteCourseAsync(int id)
        {
            Course itemCourse = _unitOfWork.Courses.Find(c => c.Id == id);
            return await _unitOfWork.Courses.DeleteAsync(itemCourse);
        }
    }
}
