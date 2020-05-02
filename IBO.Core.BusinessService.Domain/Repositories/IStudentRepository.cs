using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        //IEnumerable<Student> GetTopSellingCourses(int count);
        //IEnumerable<Student> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
