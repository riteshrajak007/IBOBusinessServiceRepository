using IBO.Core.BusinessService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IBO.Core.BusinessService.Data.Configuration
{
    public class AssessmentperiodConfiguration : IEntityTypeConfiguration<AssessmentPeriod>
    {
        public void Configure(EntityTypeBuilder<AssessmentPeriod> builder)
        {
            builder.ToTable("tblAssessmentPeriod");
            builder.HasKey(x => x.Id);
        }
    }
}
