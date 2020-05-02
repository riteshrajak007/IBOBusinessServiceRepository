using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Services
{
    public class SchoolService : ISchoolService
    {
        private  IUnitOfWork _unitOfWork;
        public SchoolService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<School> GetAllSchools()
        {
            return _unitOfWork.Schools.GetAll();
        }

        School ISchoolService.GetSchool(int id)
        {
            return _unitOfWork.Schools.Get(id);
        }

        void ISchoolService.AddSchool(School school)
        {
            _unitOfWork.Schools.Add(school);
            _unitOfWork.Complete();
        }

        void ISchoolService.UpdateSchool(int id, School itemSchool)
        {
             //var school = _unitOfWork.Schools.SingleOrDefault(c => c.Id == id);
            _unitOfWork.Schools.Update(itemSchool);
            _unitOfWork.Complete();
        }

        void ISchoolService.DeleteSchool(School school)
        {
            _unitOfWork.Schools.Remove(school);
            _unitOfWork.Complete();
        }

        void ISchoolService.AddListOfSchool(IEnumerable<School> schoolItems)
        {
            _unitOfWork.Schools.AddRange(schoolItems);
            _unitOfWork.Complete();
        }

        void ISchoolService.DeleteListOfSchool(IEnumerable<School> schoolItems)
        {
            _unitOfWork.Schools.RemoveRange(schoolItems);
            _unitOfWork.Complete();
        }

    }
}
