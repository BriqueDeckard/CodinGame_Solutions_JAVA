// -----------------------------------------------------------------------
//  <copyright file="Program.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.ApiKafka
{
    using Cassandia.ApiGateway.Kafka;

    using Cassandia.Kafka.Api;
    using Cassandia.Kafka.Net;
    using Cassandia.Notification.ApplicationService.Contract;
    using Cassandia.Notification.Infrastructure.IoC;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Collection = new ServiceCollection();
            InjectServices();
            KafkaNetWebHost.Run(Collection);
        }

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        /// <value>
        /// The collection.
        /// </value>
        private static IServiceCollection Collection { get; set; }

        /// <summary>
        /// Injects the services.
        /// </summary>
        private static void InjectServices()
        {
            NotificationInjector.Inject(Collection);
            Collection.AddScoped<IKafkaController, NotificationController>();
            Collection
                .AddScoped<IKafkaParameterConverter<NotificationParameter, NotificationParameterDto>,
                    NotificationParameterConverter>();
            Collection.AddKongKafkaGateway();
        }
    }
}