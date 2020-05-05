using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Services
{
    public static class ExceptionHelperService
    {
        public static Logger HandleException(string level, string ex, string message)
        {
            return new Logger()
            {
                Level = level,
                Exception = ex,
                Message = message,
            };
        }
    }
}
