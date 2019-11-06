using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
//Swagger

using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using IO.Swagger.Filters;

namespace API_DI
{
    public class Startup
    {
        private readonly IHostingEnvironment _hostingEnv;
        public IConfiguration Configuration { get; }
        //public IConfiguration Configuration { get; private set; }
        //private AppSettings _appSettings;

        //*******************************************************************
        public Startup(IHostingEnvironment env, IConfiguration configuration)
        {
            _hostingEnv = env;
            Configuration = configuration;
        }


        //*******************************************************************
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Add MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //Add Swagger generator
            services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("1.0.0", new Info
                 {
                     Version = "1.0.0",
                     Title = "Categorisation de demandes du service de garde",
                     Description = "Simple Inventory API (ASP.NET Core 2.0)",
                     Contact = new Contact()
                     {
                         Name = "Manuel Maldonado Ministère de la famille",
                         Url = "https://github.com/swagger-api/swagger-codegen",
                         Email = "manuel-alejandro.maldonado-rojas@mfa.gouv.qc.ca"
                     },
                     TermsOfService = ""
                 });
                 
             });
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app
                 .UseMvc()                 
                 .UseSwagger()
                 .UseSwaggerUI(c =>
                 {
                     c.RoutePrefix = "api";
                     //TODO: Either use the SwaggerGen generated Swagger contract (generated from C# classes)
                     c.SwaggerEndpoint("/swagger/1.0.0/swagger.json", "Simple Inventory API");

                    //TODO: Or alternatively use the original Swagger contract that's included in the static files
                    // c.SwaggerEndpoint("/swagger-original.json", "Simple Inventory API Original");
                });

            

        }
    }
}
