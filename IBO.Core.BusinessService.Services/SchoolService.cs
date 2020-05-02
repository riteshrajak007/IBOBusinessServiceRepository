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
        private readonly IUnitOfWork _unitOfWork;
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

        void ISchoolService.UpdateSchool(School school)
        {
            _unitOfWork.Schools.Update(school);
            _unitOfWork.Complete();
        }

        void ISchoolService.AddListOfSchool(IEnumerable<School> schoolItems)
        {
            _unitOfWork.Schools.AddRange(schoolItems);
            _unitOfWork.Complete();
        }

        void ISchoolService.DeleteSchool(School school)
        {
            _unitOfWork.Schools.Add(school);
            _unitOfWork.Complete();
        }

        void ISchoolService.DeleteListOfSchool(IEnumerable<School> schoolItems)
        {
            _unitOfWork.Schools.RemoveRange(schoolItems);
            _unitOfWork.Complete();
        }

        //public IEnumerable<Course> GetTopSellingCourses(int count)
        //{
        //    schoolboardDbContext.Schools.Include(a => a.).SingleOrDefault(a => a.Id == id);
        //    return schoolboardDbContext.Schools.Add( .Schools.orde..OrderByDescending(c => c.FullPrice).Take(count).ToList();
        //}

        //public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        //{
        //    return PlutoContext.Courses
        //        .Include(c => c.Author)
        //        .OrderBy(c => c.Name)
        //        .Skip((pageIndex - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToList();
        //}
    }
}
