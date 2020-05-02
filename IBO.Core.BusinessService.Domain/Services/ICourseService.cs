using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();

        Course GetCourse(int id);

        Course AddCourse(Course course);

        void UpdateCourse(Course course);
    }
}
