using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NoteApplicationApi.BusinessLayer.Interface;
using NoteApplicationApi.BusinessLayer.Services;
using NoteApplicationApi.BusinessLayer.Services.Repository;
using NoteApplicationApi.DataLayer;
using NoteApplicationApi.DataLayer.Context;

namespace NoteApplicationApi
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
            services.Configure<MongoDbSetting>(sp =>
            {
                sp.ConnectionString = Configuration.GetSection("NoteDatabaseSetting:ConnectionString").Value;
                sp.Database = Configuration.GetSection("NoteDatabaseSetting:Database").Value; 
            });
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<IMongoDbContext, MongoDbContext>();
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
