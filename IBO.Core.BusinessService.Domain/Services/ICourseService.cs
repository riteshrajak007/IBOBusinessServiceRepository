using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface ICourseService
    {
        Task<ICollection<Course>> GetAllCourseAsync();

        Task<Course> GetCourseAsync(int id);

        Task<ICollection<Course>> GetAllCourseByIdAsync(int id);

        Task<Course> UpdateCourseAsync(Course t, int key);

        Task<Course> AddCourseAsync(Course t);

        Task<int> DeleteCourseAsync(int id);
    }
}
