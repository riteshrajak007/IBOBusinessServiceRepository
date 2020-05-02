using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Data.Repositories
{
    public class ProgramRepository : Repository<Program>, IProgramRepository
    {
        public ProgramRepository(BusinessServiceDbContext context)
          : base(context)
        {
        }
        public BusinessServiceDbContext BusinessServiceDbContext
        {
            get { return Context as BusinessServiceDbContext; }
        }
    }

}
