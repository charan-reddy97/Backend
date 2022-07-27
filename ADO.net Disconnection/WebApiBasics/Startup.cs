using Books.Core;
using Books.Core.Repository;
using Books.Core.SMS;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBasics.Filters;
using WebApiBasics.MiddleWares;

namespace WebApiBasics
{
    public class Startup  
    {
        IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy("origin", builder=> {
                    builder.WithOrigins("http://localhost:61859").AllowAnyHeader().AllowAnyMethod();                
                });
            });
            services.AddControllers(options=> 
            {
                options.Filters.Add(new CheckExceptionAttribute());
            }).AddXmlSerializerFormatters();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "mybook.com",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is My secret "))

                    };

                });
            services.AddSwaggerGen(d =>
            {
                d.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "My Library Api Documentation",
                    Description = "Complete reference of WebApiBasics"
                });
                var docpath = Path.Combine(System.AppContext.BaseDirectory, "webapibasics.xml");
                d.IncludeXmlComments(docpath);
            });
            services.AddScoped<ISmsService, JIOSmsService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddDbContext<BookDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetValue<string>("Client:DataBaseConnection"));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseMiddleware<LogRequestMiddleware>();
            app.UseCors("origin");
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseStaticFiles();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Web Api"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
