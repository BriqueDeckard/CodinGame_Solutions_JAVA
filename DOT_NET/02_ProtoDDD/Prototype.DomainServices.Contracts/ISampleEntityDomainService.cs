using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.Dtos;

namespace Prototype.DomainServices.Contracts
{
    /// <summary>
    ///     Interface for domain services.
    ///     Encapsulates business logic that doesn't
    ///     naturally fit within a domain object, and
    ///     are NOT typical CRUD operations
    ///     – those would belong to a Repository.
    /// </summary>
    public interface ISampleEntityDomainService
    {
        /// <summary>
        ///     Gets a new entity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="price">The price.</param>
        /// <returns></returns>
        public SampleEntity GetANewEntity(string value, double price);

        /// <summary>
        ///     Gets the entity's price log.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <param name="newBase">The new base.</param>
        /// <returns></returns>
        public double GetTheEntityPriceLog(SampleEntityDto dto, double newBase);
    }
}