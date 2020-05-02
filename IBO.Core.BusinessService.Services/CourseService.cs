using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Services
{
    public class CourseService : ICourseService
    {
        private IUnitOfWork _unitOfWork;
        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddCourse(Course course)
        {
            _unitOfWork.Courses.Add(course);
            _unitOfWork.Complete();
            throw new NotImplementedException();
        }

        public void DeleteCourse(Course course)
        {
            _unitOfWork.Courses.Remove(course);
            _unitOfWork.Complete();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _unitOfWork.Courses.GetAll();
        }

        public Course GetCourse(int id)
        {
            return _unitOfWork.Courses.Get(id);
        }

        public void UpdateCourse(int id, Course course)
        {
            _unitOfWork.Courses.Update(course);
            _unitOfWork.Complete();
        }
    }
}
