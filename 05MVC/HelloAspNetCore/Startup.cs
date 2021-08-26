using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelloAspNetCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
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
                    //throw new Exception("error");
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            // the job of this method is to call "Run" or "Use" methods on
            // the IApplicationBuilder. each one sets up a "middleware".
            // every HTTP request goes through the middleware in order.

            app.UseStaticFiles();

            app.Run(async context =>
            {
                // this object has all the details of the request
                HttpRequest request = context.Request;

                string path = request.Path;

                // we can modify this object to set up the response.
                HttpResponse response = context.Response;

                response.ContentType = "text/html";
                await response.WriteAsync(@$"<!DOCTYPE html>
<html>
  <head>
  </head>
  <body>
    Hello {path}!
  </body>
</html>
");
            });
        }
    }
}
