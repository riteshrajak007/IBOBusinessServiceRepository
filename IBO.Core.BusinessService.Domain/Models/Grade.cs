using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public string Level { get; set; }

        public string FromMarks { get; set; }
        public string ToMarks { get; set; }
    }
}
