﻿using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface ISchoolService
    {
        IEnumerable<School> GetAllSchools();

        School GetSchool(int id);

        void AddSchool(School school);

        void UpdateSchool(int id, School school);

        void AddListOfSchool(IEnumerable<School> schoolItems);

        void DeleteSchool(School school);

        void DeleteListOfSchool(IEnumerable<School> schoolItems);

    }
}
