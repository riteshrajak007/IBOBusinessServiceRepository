using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Country { get; set; }

        public bool IsActive { get; set; }

        public int LanguageId { get; set; }

        public int SchoolId { get; set; }

        //public int CourseId { get; set; }

        public int GradeId { get; set; }

        public int ProgramId { get; set; }

    }

    //public Enum Gender 
    //{
    //    Male  = 0
    //    Female = 1
    //}
}
