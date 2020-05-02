using IBO.Core.BusinessService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace IBO.Core.BusinessService.Data.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("tblLanguage");
            builder.HasKey(x => x.Id);

            //HasRequired(c => c.Author)
            //    .WithMany(a => a.Courses)
            //    .HasForeignKey(c => c.AuthorId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.Cover)
            //    .WithRequiredPrincipal(c => c.Course);

            //HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses)
            //    .Map(m =>
            //    {
            //        m.ToTable("CourseTags");
            //        m.MapLeftKey("CourseId");
            //        m.MapRightKey("TagId");
            //    });
        }
    }
}
