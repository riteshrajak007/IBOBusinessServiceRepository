using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Services;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Services
{
    public class LoggerService : ILoggerService
    {
        private IUnitOfWork _unitOfWork;
        public LoggerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        /// Insert into tblLog table
        /// </summary>
        /// <param name="logger"></param>
        /// <returns></returns>
        public async Task<bool> InsertIntoLog(Logger logger)
        {
            var itemLog = new Logger
            {
                Exception = logger.Exception,
                Message = logger.Message,
                Level = logger.Level,
                Date = logger.Date

            };
            await _unitOfWork.Loggers.InsertIntoLog(itemLog);
            return true;
        }

    }
}
