using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Domain.Repositories
{
    public interface ILoggerRepository
    {
        Task<bool> InsertIntoLog(Logger logger);
    }
}
