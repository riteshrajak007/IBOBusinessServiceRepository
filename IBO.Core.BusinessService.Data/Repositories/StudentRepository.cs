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

        public BusinessServiceDbContext BusinessServiceDbContext
        {
            get { return Context as BusinessServiceDbContext; }
        }
    }
}
