using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class AssessmentPeriod
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        //public int ProgramId { get; set; }
        public virtual Program Program { get; set; }
    }
}
