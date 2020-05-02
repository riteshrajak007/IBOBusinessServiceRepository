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
        private IBoardRepository _board;
        private IProgramRepository _program;
        private ICourseRepository _course;

        public UnitOfWork(BusinessServiceDbContext context)
        {
            _repocontext = context;
        }

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

        public ICourseRepository Courses
        {
            get
            {
                if (_course == null)
                {
                    _course = new CourseRepository(_repocontext);
                }

                return _course;
            }
        }

        public IBoardRepository Boards
        {
            get
            {
                if (_board == null)
                {
                    _board = new BoardRepository(_repocontext);
                }

                return _board;
            }
        }

        public IProgramRepository Programs
        {
            get
            {
                if (_program == null)
                {
                    _program = new ProgramRepository(_repocontext);
                }

                return _program;
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
