using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Language
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        //public virtual School School { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
