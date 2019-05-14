using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreApps.StarterKit.DataAccess;
using CreApps.StarterKit.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace WebApiExample
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
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {

                        builder.WithOrigins("http://localhost:52047").AllowAnyHeader().AllowAnyMethod();
                    });

            });
            services.AddDbContext<StarterKitDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("StarterKitDbContext")));

            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddTransient<IClienteService, ClienteService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


           


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
