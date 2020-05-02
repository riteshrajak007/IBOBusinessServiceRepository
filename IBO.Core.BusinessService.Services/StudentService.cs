using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
       
        public IEnumerable<Student> GetAllStudents()
        {
            return _unitOfWork.Students.GetAll();
        }
        public void AddStudent(Student student)
        {
            _unitOfWork.Students.Add(student);
            _unitOfWork.Complete();
        }
        public Student GetStudent(int id)
        {
            return _unitOfWork.Students.Get(id);
        }

        public void UpdateStudent(Student student)
        {
            _unitOfWork.Students.Update(student);
            _unitOfWork.Complete();
        }
    }
}
