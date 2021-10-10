using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _01_SampleWebApi
{
    public class Program
    {
        /// <summary>
        /// The static Main() method is automatically called when the
        ///  application starts. 
        /// It creates a default web host using the startup configuration, 
        /// exposing the application via HTTP through a specific port 
        /// (by default, port 5000 for HTTP and 5001 for HTTPS).
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// the webBuilder.UseStartup() method refers to the Startup type.
        ///  This type is defined by the Startup class in the Startup.cs file.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
