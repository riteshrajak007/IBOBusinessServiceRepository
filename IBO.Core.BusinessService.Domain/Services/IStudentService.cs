using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();

        Student GetStudent(int id);

        void AddStudent(Student student);

        void UpdateStudent(int id, Student student);

        void DeleteStudent(Student student);
    }
}
