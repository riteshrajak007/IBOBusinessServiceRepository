using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Board
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Program> Programs { get; set; }

        //public virtual ICollection<School> Schools { get; set; }

    }
}
