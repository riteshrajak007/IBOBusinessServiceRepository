using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Country { get; set; }

        public string Language { get; set; }

        public string Board { get; set; }

    }
}
