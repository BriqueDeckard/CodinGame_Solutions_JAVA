// -----------------------------------------------------------------------
//  <copyright file="SampleEntityRepositoryTests.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using DDDMicroservice.Infrastructure.Data.UnitOfWork.Repositories;

namespace DDDMicroservice.CrossCutting.Tests
{
    using System;
    using System.Data.Common;
    using DDDMicroservice.Domain.Aggregates;
    using DDDMicroservice.Infrastructure.Data.UnitOfWork;
    using DDDMicroservice.Infrastructure.IoC;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    /// <summary>
    /// Tests class for SampleEntityRepository
    /// </summary>
    /// <seealso cref="DDDMicroservice.CrossCutting.Tests.DddMicroserviceTest" />
    public class SampleEntityRepositoryTests : DddMicroserviceTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleEntityRepositoryTests" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public SampleEntityRepositoryTests()
        {
            _repository = this.Provider.GetService<ISampleRepository>();
        }

        /// <summary>
        /// Tests the add entity.
        /// </summary>
        [Fact]
        public void TestAddEntity()
        {
            SampleEntity entity = new SampleEntity
            {
                BooleanProperty = false,
                NumberProperty = 42,
                StringProperty = "blabla"
            };

            bool test = false;
            try
            {
                this._repository.AddEntity(entity);
                test = true;
            }
            catch (DbException e)
            {
                test = false;
                Console.WriteLine(e);
                throw;
            }

            Assert.True(test);
        }

        /// <summary>
        /// Injects the services.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        protected override void InjectServices(IServiceCollection serviceCollection)
        {
            SampleInjector.Inject(serviceCollection);
        }

        /// <summary>
        /// Gets the repository.
        /// </summary>
        /// <value>
        /// The repository.
        /// </value>
        private ISampleRepository _repository { get; }
    }
}