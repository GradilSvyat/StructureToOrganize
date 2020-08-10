using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace StructureToOrganize
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
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.RequireHttpsMetadata = false;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true, // ��������, ����� �� �������������� �������� ��� ��������� ������
                            ValidIssuer = AuthOptions.ISSUER, // ������, �������������� ��������
                            ValidateAudience = true, // ����� �� �������������� ����������� ������
                            ValidAudience = AuthOptions.AUDIENCE, // ��������� ����������� ������
                            ValidateLifetime = true, // ����� �� �������������� ����� �������������
                            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(), // ��������� ����� ������������
                            ValidateIssuerSigningKey = true, // ��������� ����� ������������
                        };
                    });
            //services.AddDbContext<AplicationDBContext>(p => 
            //{ 
            //    p.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = IdentityUser; Trusted_Connection = True; "); 
            //});
            //services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AplicationDBContext>();
            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
