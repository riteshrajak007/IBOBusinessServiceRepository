using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Api.Resources
{
    public class ProgramDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Board Board { get; set; }
    }
}
