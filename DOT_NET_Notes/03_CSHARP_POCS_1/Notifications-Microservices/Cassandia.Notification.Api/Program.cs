//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Api
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Main Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Web Host Builder. Builds and configure web server
        /// </summary>
        /// <param name="args">
        /// arguments to pass to the web server
        /// </param>
        /// <returns>
        /// A web host builder
        /// </returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args">
        /// Arguments to use to launch program
        /// </param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
    }
}