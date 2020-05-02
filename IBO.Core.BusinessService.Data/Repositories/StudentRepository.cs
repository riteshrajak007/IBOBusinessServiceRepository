using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(BusinessServiceDbContext context)
            : base(context)
        {
        }
        //public Student AddStudent(Student student)
        //{
        //    schoolboardDbContext.Students.Add(student);
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Student> GetAllStudents()
        //{
        //    schoolboardDbContext.Students.GetAll();
        //    throw new NotImplementedException();
        //}

        //public Student GetStudent(int id)
        //{
        //    schoolboardDbContext.Get(id);
        //    throw new NotImplementedException();
        //}

        //public void UpdateStudent(Student student)
        //{
        //    schoolboardDbContext.Update(student);
        //    throw new NotImplementedException();
        //}

        public BusinessServiceDbContext schoolboardDbContext
        {
            get { return Context as BusinessServiceDbContext; }
        }
    }
}
