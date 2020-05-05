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

        public override Student UpdateStudent(Student t, object key)
        {
            if (t == null)
                return null;
            Student exist = _context.Set<Student>().Find(key);
            if (exist != null)
            {
                exist.Name = t.Name;
                exist.Language = t.Language;
                exist.Country = t.Country;
                exist.DateOfBirth = t.DateOfBirth;
                exist.Grade = t.Grade;
                exist.IsActive = t.IsActive;

                _context.Entry(exist).CurrentValues.SetValues(exist);
                //_context.SaveChanges();
            }
            return exist;
        }

        public BusinessServiceDbContext BusinessServiceDbContext
        {
            get { return _context as BusinessServiceDbContext; }
        }
    }
}
