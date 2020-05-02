using AutoMapper;
using IBO.Core.BusinessService.Data;
using IBO.Core.BusinessService.Data.Repositories;
using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace IBO.Core.BusinessService.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            var connectionString = Configuration.GetConnectionString("SchoolBoardDbContext");
            services.AddScoped<IUnitOfWork>(sp => new UnitOfWork(new BusinessServiceDbContext()));
            services.AddDbContext<BusinessServiceDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:SchoolBoardDbContext"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
