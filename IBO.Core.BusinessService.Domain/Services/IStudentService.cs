using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IStudentService
    {
        Task<ICollection<Student>> GetAllStudentAsync();

        Task<Student> GetStudentAsync(int id);

        Task<ICollection<Student>> GetAllStudentByIdAsync(int id);

        Task<Student> UpdateStudentAsync(Student t, int key);

        Task<Student> AddStudentAsync(Student t);

        Task<int> DeleteStudentAsync(int id);
    }
}
