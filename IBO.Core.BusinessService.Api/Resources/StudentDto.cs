using System;

namespace IBO.Core.BusinessService.Api.Resources
{
    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Country { get; set; }

        public bool IsActive { get; set; }

        public string Language { get; set; }

        public string School { get; set; }

        public string Grade { get; set; }

    }
}
