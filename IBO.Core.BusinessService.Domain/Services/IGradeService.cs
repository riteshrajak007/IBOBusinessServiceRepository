using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IGradeService
    {
        IEnumerable<Grade> GetAllGrades();

        Grade GetGrade(int id);

        Grade AddGrade(Grade Grade);

        void UpdateGrade(Grade Grade);
    }
}
