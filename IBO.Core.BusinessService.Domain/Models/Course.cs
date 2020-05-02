using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public virtual Program Program { get; set; }

        //public int ProgramId { get; set; }
    }
}
