using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Data.Repositories
{
    public class LoggerRepository : Repository<Logger>, ILoggerRepository
    {
        public LoggerRepository(BusinessServiceDbContext context)
          : base(context)
        {
        }

        /// <summary>
        /// Insert log in tblLog
        /// </summary>
        /// <param name="logger"></param>
        /// <returns></returns>
        public async Task<bool> InsertIntoLog(Logger logger)
        {
            logger.Date = DateTime.Now;
            await _context.AddAsync(logger);
            await _context.SaveChangesAsync();
            return true;
        }
        public BusinessServiceDbContext BusinessServiceDbContext
        {
            get { return _context as BusinessServiceDbContext; }
        }
    }
}
