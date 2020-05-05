using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Api.Resources
{
    public class LoggerDTO
    {
        public class LoggerDTOs
        {
            public string Exception { get; set; }
            public string Message { get; set; }
            public DateTime Date { get; set; }
            public string Level { get; set; }
        }
    }
}
