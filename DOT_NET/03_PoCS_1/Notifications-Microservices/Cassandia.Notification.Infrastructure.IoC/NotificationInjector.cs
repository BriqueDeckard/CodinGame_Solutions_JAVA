//-----------------------------------------------------------------------
// <copyright file="NotificationInjector.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Cassandia.Notification.Tests")]

namespace Cassandia.Notification.Infrastructure.IoC
{
    using Cassandia.Notification.Infrastructure.Data.Serializer;
    using Cassandia.ApplicationService.Contract.Core;
    using Cassandia.ApplicationService.Contract.Core.Mappers;
    using Cassandia.Domain.Core;
    using Cassandia.Domain.Core.Factories;
    using Cassandia.Domain.Core.Specification;
    using Cassandia.Infrastructure.Data.Core.MongoDB;
    using Cassandia.Notification.ApplicationService;
    using Cassandia.Notification.ApplicationService.Contract;
    using Cassandia.Notification.Domain;
    using Cassandia.Notification.Domain.Aggregates;
    using Cassandia.Notification.Infrastructure.Data;
    using Microsoft.Extensions.DependencyInjection;
    using Swashbuckle.AspNetCore.Swagger;
    using Cassandia.Infrastructure.Data.Core;

    /// <summary>
    /// Injects dependencies in the micro-service. Has access to internal classes from other
    /// micro-services namespaces.
    /// </summary>
    public static class NotificationInjector
    {
        /// <summary>
        /// Injects specified services
        /// </summary>
        /// <param name="services">
        /// Service collection to inject
        /// </param>
        public static void Inject(IServiceCollection services)
        {
            InjectServices(services);
            RegisterClasses();

            services.AddScoped<IObjectRepository<Domain.Aggregates.CassandiaNotification>, NotificationRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<ISerializer, Serializer>();

#if DEBUG
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new Info()
            {
                Title = "Notification API",
                Version = "v1",
                Description = "" // TODO : Add Description
            }));
#endif
        }

        /// <summary>
        /// Injects micro-service services
        /// </summary>
        /// <param name="services">
        /// Service collection to inject
        /// </param>
        internal static void InjectServices(IServiceCollection services)
        {
            services
                .AddScoped<ICoreApplicationService<CassandiaNotificationDto, NotificationParameterDto, string>, NotificationApplicationService>();
            services.AddScoped<IObjectRepository<Domain.Aggregates.CassandiaNotification>, NotificationRepository>();
            services.AddScoped<IFactory<Domain.Aggregates.CassandiaNotification, CassandiaNotificationDto, string>, NotificationFactory>();
            services
                .AddScoped<IBusinessSpecification<Domain.Aggregates.CassandiaNotification, NotificationParameterDto, string>, NotificationBusinessSpecification
                >();
            services.AddScoped<IMapper<Domain.Aggregates.CassandiaNotification>, NotificationMapper>();
            services.AddScoped<INotificationApplicationService, NotificationApplicationService>();
        }

        /// <summary>
        /// Registers entities to use with MongoDb
        /// </summary>
        internal static void RegisterClasses()
        {
            MongoDbRepositoryBase<Domain.Aggregates.CassandiaNotification>.RegisterClass();
        }
    }
}