using IBO.Core.BusinessService.Data.Configuration;
using IBO.Core.BusinessService.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace IBO.Core.BusinessService.Data
{
    public class BusinessServiceDbContext : DbContext
    {
        public BusinessServiceDbContext(DbContextOptions<BusinessServiceDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        
        public virtual DbSet<School> Schools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DNETAZ14;Initial Catalog=SchoolBoardDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }

    }
}
