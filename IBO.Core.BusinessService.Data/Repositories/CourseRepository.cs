using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Data.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(BusinessServiceDbContext context)
          : base(context)
        {
        }
        public BusinessServiceDbContext BusinessServiceDbContext
        {
            get { return _context as BusinessServiceDbContext; }
        }
    }
    
}
