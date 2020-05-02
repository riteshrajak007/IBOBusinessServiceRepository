using IBO.Core.BusinessService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        ISchoolRepository Schools { get; }
        IProgramRepository Programs { get; }
        ICourseRepository Courses { get; }
        IBoardRepository Boards { get; }
        int Complete();
    }
}
