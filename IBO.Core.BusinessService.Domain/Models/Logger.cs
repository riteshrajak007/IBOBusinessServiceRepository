using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Logger
    {
        public int Id { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string Level { get; set; }
    }
}
