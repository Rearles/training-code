using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HelloAspNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // step 1 - "startup"
            IHostBuilder hostBuilder = CreateHostBuilder(args);
            IHost host = hostBuilder.Build();
            // step 2 - run, listen for http connections forever
            host.Run();
            // we never get here (unless we put a try catch out here or something)
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // applies defaults and references the Startup class for our own
            // custom behavior
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
