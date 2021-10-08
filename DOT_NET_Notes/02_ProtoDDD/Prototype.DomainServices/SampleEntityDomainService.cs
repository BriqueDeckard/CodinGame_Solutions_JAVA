using System;
using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.Dtos;
using Prototype.Domain.Contracts.SeedWork;
using Prototype.DomainServices.Contracts;

namespace Prototype.DomainServices
{
    /// <summary>
    ///     Implementation for domain services
    /// </summary>
    /// <seealso cref="Prototype.DomainServices.Contracts.ISampleEntityDomainService" />
    public class SampleEntityDomainService : ISampleEntityDomainService
    {
        /// <summary>
        ///     The sample entity repository
        /// </summary>
        private IRepository _sampleEntityRepository;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SampleEntityDomainService" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public SampleEntityDomainService(IRepository repository)
        {
            Console.WriteLine("\nSampleEntityDomainService : Initialize DomainService for SampleEntity ... ");
            _sampleEntityRepository = repository;
            Console.WriteLine("SampleEntityDomainService : ... DomainService initialized.");
        }

        /// <summary>
        ///     Gets a new entity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="price">The price.</param>
        /// <returns></returns>
        public SampleEntity GetANewEntity(string value, double price)
        {
            Console.WriteLine("\nSampleEntityDomainService : Get new entity ... ");
            var entity = new SampleEntity(value, price);

            Console.WriteLine("SampleEntityDomainService : String value -> {0}", entity.StringValue);
            Console.WriteLine("SampleEntityDomainService : String manipulation  ");
            entity.SomeStringManipulation(" #WAS MANIPULATED#");
            Console.WriteLine("SampleEntityDomainService : String value -> {0}", entity.StringValue);

            return entity;
        }


        /// <summary>
        ///     Gets the entity's price log.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <param name="newBase">The new base.</param>
        /// <returns></returns>
        public double GetTheEntityPriceLog(SampleEntityDto dto, double newBase)
        {
            Console.WriteLine("\nSampleEntityService : Get the log of price ... ");
            var log = Math.Log(dto.PriceValue, newBase);
            Console.WriteLine("Price log : {0}", log);
            return log;
        }
    }
}