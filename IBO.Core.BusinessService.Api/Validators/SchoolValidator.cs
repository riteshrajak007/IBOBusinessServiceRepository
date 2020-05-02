using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBO.Core.BusinessService.Api.Validators
{
    public class SchoolValidator
    {
        private readonly ISchoolService _schoolsvc;
        public SchoolValidator(ISchoolService schoolsvc)
        {
            _schoolsvc = schoolsvc;
        }
        public bool SchoolDtoExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
