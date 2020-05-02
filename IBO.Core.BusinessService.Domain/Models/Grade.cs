using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public string Level { get; set; }

        public int FromMarks { get; set; }
        public int ToMarks { get; set; }
    }
}
