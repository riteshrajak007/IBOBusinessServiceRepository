using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Data.Repositories
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        public SchoolRepository(BusinessServiceDbContext context)
          : base(context)
        {
        }
        public override School UpdateStudent(School t, object key)
        {
            if (t == null)
                return null;
            School exist = _context.Set<School>().Find(key);
            if (exist != null)
            {
                exist.Name = t.Name;
                exist.Language = t.Language;
                exist.Board = t.Board;
                exist.Country = t.Country;
                
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
