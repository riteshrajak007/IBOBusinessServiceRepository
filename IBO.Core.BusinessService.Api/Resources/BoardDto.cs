using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Api.Resources
{
    public class BoardDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Program> Programs { get; set; }
    }
}
