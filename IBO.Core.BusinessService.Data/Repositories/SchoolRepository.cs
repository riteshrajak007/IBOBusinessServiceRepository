﻿using IBO.Core.BusinessService.Domain.Models;
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
        public BusinessServiceDbContext BusinessServiceDbContext
        {
            get { return Context as BusinessServiceDbContext; }
        }
    }
}