using IBO.Core.BusinessService.Data.Configuration;
using IBO.Core.BusinessService.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace IBO.Core.BusinessService.Data
{
    public class BusinessServiceDbContext : DbContext
    {
        public BusinessServiceDbContext(DbContextOptions options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = true;
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<AssessmentPeriod> AssessmentPeriods { get; set; }
        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<School> Schools { get; set; }

        //protected override void OnModelCreating

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString: @"Data Source=DNETAZ14;Initial Catalog=SchoolBoardDb;Integrated Security=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssessmentperiodConfiguration());
            modelBuilder.ApplyConfiguration(new BoardConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProgramConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }

    }
}
