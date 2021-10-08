//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------



namespace Cassandia.Notification.Api
{
    using System;
    using Cassandia.Api.Core.Converters;
    using Cassandia.ApiGateway;
    using Cassandia.Notification.ApplicationService.Contract;
    using Cassandia.Notification.Infrastructure.IoC;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Start up class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Application Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Startup Constructor to inject configuration
        /// </summary>
        /// <param name="configuration">
        /// </param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Configures application This method gets called by the runtime. Use this method to
        /// configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">
        /// Application Builder
        /// </param>
        /// <param name="env">
        /// Environment
        /// </param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
#if DEBUG
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Notification API");
                c.RoutePrefix = String.Empty;
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
#endif
            //TODO : Uncomment this before pushing
            // app.ApplicationServices.GetRequiredService<IServiceGateway>();

            app.UseMvc();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// Configures services for dependency injection
        /// </summary>
        /// <param name="services">
        /// Service collection to inject in.
        /// </param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            NotificationInjector.Inject(services);
            services.AddKongGateway();
            services
                .AddScoped<IParameterConverter<NotificationParameter, NotificationParameterDto>, NotificationParameterConverter>();
        }
    }
}