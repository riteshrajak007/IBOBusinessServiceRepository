using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //[DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Country { get; set; }

        public bool IsActive { get; set; }

        public string Language { get; set; }

        public string School { get; set; }

        public string Grade { get; set; }

    }

}
