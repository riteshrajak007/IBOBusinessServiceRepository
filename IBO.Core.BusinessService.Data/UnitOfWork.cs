using IBO.Core.BusinessService.Data.Repositories;
using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private BusinessServiceDbContext _repocontext;
        private IStudentRepository _student;
        private ISchoolRepository _school;

        public UnitOfWork(BusinessServiceDbContext context)
        {
            _repocontext = context;
        }

        //Do this for every new Repository Added
        public IStudentRepository Students
        {
            get
            {
                if (_student == null)
                {
                    _student = new StudentRepository(_repocontext);
                }

                return _student;
            }
        }

        public ISchoolRepository Schools 
        {
            get
            {
                if (_school == null)
                {
                    _school = new SchoolRepository(_repocontext);
                }

                return _school;
            }
        }

        public int Complete()
        {
            return _repocontext.SaveChanges();
        }

        public void Dispose()
        {
            _repocontext.Dispose();
        }
    }
}
