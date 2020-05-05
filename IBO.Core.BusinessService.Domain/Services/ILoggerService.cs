using IBO.Core.BusinessService.Domain.Models;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface ILoggerService
    {
        Task<bool> InsertIntoLog(Logger logger);
    }
}
