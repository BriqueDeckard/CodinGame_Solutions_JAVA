// -----------------------------------------------------------------------
//  <copyright file="SampleEntityFactoryTests.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.CrossCutting.Tests
{
    using DDDMicroservice.Infrastructure.IoC;

    using DDDMicroservice.ApplicationService.Contract;
    using DDDMicroservice.Domain;
    using Microsoft.Extensions.DependencyInjection;

    using DDDMicroservice.Domain.Aggregates;
    using Xunit;

    /// <summary>
    /// "SampleEntityFactoryTests" class.
    /// </summary>
    /// <seealso cref="DDDMicroservice.CrossCutting.Tests.DddMicroserviceTest" />
    public class SampleEntityFactoryTests : DddMicroserviceTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleEntityFactoryTests" /> class.
        /// </summary>
        public SampleEntityFactoryTests()
        {
            this.Factory = this.Provider.GetService<ISampleEntityFactory>();
        }

        /// <summary>
        /// Gets the factory.
        /// </summary>
        /// <value>
        /// The factory.
        /// </value>
        public ISampleEntityFactory Factory { get; }

        /// <summary>
        /// Tests the dto to entity conversion.
        /// </summary>
        [Fact]
        public void TestTheDtoToEntityConversion()
        {
            var dto = new SampleEntityDto()
            {
                BooleanProperty = false,
                Id = "001",
                NumberProperty = 001,
                StringProperty = "Sample string."
            };

            SampleEntity entity = this.Factory.ConvertADtoIntoAnEntity(dto);

            Assert.NotNull(entity);
            Assert.Equal(dto.StringProperty, entity.StringProperty);
            Assert.Equal(dto.BooleanProperty, entity.BooleanProperty);
            Assert.Equal(dto.NumberProperty, entity.NumberProperty);
        }

        [Fact]
        public void TestTheEntityToDtoConversion()
        {
            var entity = new SampleEntity()
            {
                BooleanProperty = false,
                Id = "002",
                NumberProperty = 002,
                StringProperty = "Sample string 2"
            };

            SampleEntityDto dto = this.Factory.ConvertAnEntityIntoADto(entity);
            Assert.NotNull(entity);
            Assert.Equal(dto.StringProperty, entity.StringProperty);
            Assert.Equal(dto.BooleanProperty, entity.BooleanProperty);
            Assert.Equal(dto.NumberProperty, entity.NumberProperty);
        }

        /// <summary>
        /// Injects the services.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        protected override void InjectServices(IServiceCollection serviceCollection)
        {
            SampleInjector.Inject(serviceCollection);
        }
    }
}