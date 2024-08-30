using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)

        {
            // Register MVC Built in Services to the container
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                }); endpoints.MapGet("/ali", async context =>
                {
                    await context.Response.WriteAsync("Hello 3laaaayeeee   !");
                });

                // Routing

                endpoints.MapControllerRoute(

                    name: "dafault",
                    // No Of Segments 
                    pattern: "{controller=Movie}/{action}/{id:int?}/{name:alpha?}" // New Syntax 
                    // Defaults Value 
                    //defaults:new {Controller="Movie ",Action=" GetMovie"} Old Syntax
                    //constraints  & Constraints Description
                    // constraints:new {id =new IntRouteConstraint()}  //Old Syntax 


                    );
            });
        }
    }
}
