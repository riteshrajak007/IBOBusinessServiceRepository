using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Api.Resources
{
    public class SchoolDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public Language Language { get; set; }

        public Board Board { get; set; }

    }
}
