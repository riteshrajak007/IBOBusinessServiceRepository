using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Data.Repositories
{
    public class BoardRepository : Repository<Board>, IBoardRepository
    {
        public BoardRepository(BusinessServiceDbContext context)
          : base(context)
        {
        }
        public BusinessServiceDbContext BusinessServiceDbContext
        {
            get { return _context as BusinessServiceDbContext; }
        }
    }
}
