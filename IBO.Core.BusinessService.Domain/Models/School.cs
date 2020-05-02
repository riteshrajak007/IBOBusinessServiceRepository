using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class School
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int Country { get; set; }

        public string User { get; set; } //Teacher,principal, cordinator ---implement  Enum for this 

        public int BoardId { get; set; }

        public int LanguageId { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
