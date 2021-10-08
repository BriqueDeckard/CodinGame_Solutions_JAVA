// -----------------------------------------------------------------------
//  <copyright file="SampleInjector.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using DDDMicroservice.Infrastructure.Data.UnitOfWork.Repositories;

namespace DDDMicroservice.Infrastructure.IoC
{
    using Microsoft.Extensions.Configuration;

    using DDDMicroservice.Domain;
    using DDDMicroservice.Domain.Aggregates;
    using DDDMicroservice.Infrastructure.Data.UnitOfWork;
    using Microsoft.Extensions.DependencyInjection;
    using DDDMicroservice.ApplicationService;
    using DDDMicroservice.ApplicationService.Contract;
    using DDDMicroservice.Infrastructure.Data;

    /// <summary>
    /// IoC injector for app.
    /// </summary>
    public class SampleInjector
    {
        /// <summary>
        /// Injects the specified services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void Inject(IServiceCollection services)
        {
            InjectServices(services);
        }

        /// <summary>
        /// Injects the services.
        /// </summary>
        /// <param name="services">The services.</param>
        internal static void InjectServices(IServiceCollection services)
        {
            services.AddScoped<ISampleEntityFactory, SampleEntityFactory>();
            services.AddScoped<ISampleRepository, SampleRepository>();
            services.AddScoped<ISampleApplicationService, SampleApplicationService>();
            /*
            services.AddSingleton<ISampleDatabaseSettings>(
                sp =>
                    sp.GetRequiredService<IOptions<SampleDatabaseSettings>>().Value);
                    */
        }
    }
}