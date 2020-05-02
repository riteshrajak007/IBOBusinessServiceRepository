using IBO.Core.BusinessService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Services
{
    public interface IAssessmentPeriodService
    {
        IEnumerable<AssessmentPeriod> GetAllAssessmentPeriods();

        AssessmentPeriod GetAssessmentPeriod(int id);

        void AddAssessmentPeriod(AssessmentPeriod assessmentPeriod);

        void UpdateAssessmentPeriod(AssessmentPeriod assessentPeriod);

        void DeleteAssessmentPeriod(AssessmentPeriod assessentPeriod);
    }
}
