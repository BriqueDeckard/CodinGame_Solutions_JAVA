// -----------------------------------------------------------------------
//  <copyright file="DDDMicroserviceTest.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.CrossCutting.Tests
{
    using Microsoft.Extensions.Configuration;

    using System;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// DddMicroserviceTest class.
    /// </summary>
    public abstract class DddMicroserviceTest
    {
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DddMicroserviceTest"/> class.
        /// </summary>
        protected DddMicroserviceTest()
        {
            this.InitServiceProvider();
        }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        protected IServiceProvider Provider { get; set; }

        /// <summary>
        /// Injects the services.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        protected abstract void InjectServices(IServiceCollection serviceCollection);

        /// <summary>
        /// Initializes the service provider.
        /// </summary>
        private void InitServiceProvider()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            this.InjectServices(serviceCollection);
            this.Provider = serviceCollection.BuildServiceProvider();
        }
    }
}