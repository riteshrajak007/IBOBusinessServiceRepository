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
            //_unitOfWork.Cou
            throw new NotImplementedException();
        }

        public void DeleteCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(int id, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
