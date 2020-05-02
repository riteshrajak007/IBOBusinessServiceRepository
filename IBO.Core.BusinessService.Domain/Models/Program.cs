using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Program
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Board Board { get; set; }

        //public int BoardId { get; set; }

        public virtual ICollection<AssessmentPeriod> AssessmentPeriods { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
