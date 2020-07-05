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

namespace PetStore.API
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

            // Register the Swagger services
            services.AddSwaggerDocument(
                config =>
                {
                    config.PostProcess = document =>
                    {
                        document.Info.Version = "v1";
                        document.Info.Title = "ToDo API";
                        document.Info.Description = "<h1>Welcome Medisked Colleagues!</h1> <p>If you are reading this it means you are interested in learning more about how OpenAPI can make our lives easier, and our projects clearer.</p> <p>Please click on the 'PetStore' header below to expand the web methods and examine our API (and test it without the need for Postman!).</p><p><b>Important Note: </b> <ul> <li> It is expected you will get a 'NotImplementedException' error.</li> <li>This project is only to show the scaffolding capabilites of using OpenAPI and Swagger.</li></ul></p><br/>";
                        document.Info.Contact = new NSwag.OpenApiContact
                        {
                            Name = "Paul Walter",
                            Email = "paul.walter.software@gmail.com",
                            Url = "https://github.com/paulito-bandito"
                        };
                        document.Info.License = new NSwag.OpenApiLicense
                        {
                            Name = "Use under LICX",
                            Url = "https://example.com/license"
                        };
                    };
                }
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Register the Swagger generator and the Swagger UI middlewares
                app.UseOpenApi();
                app.UseSwaggerUi3();
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
