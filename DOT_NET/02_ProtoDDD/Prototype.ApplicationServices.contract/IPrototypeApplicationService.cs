using System.Collections.Generic;
using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.Dtos;
using Prototype.Domain.SelectBuilders;

namespace Prototype.ApplicationServices.Contracts
{
    /// <summary>
    ///     Contract for application services.
    ///     Here are exposed operations that external consumers use to talk to the system (like a web service).
    ///     Services must not break the layer separation, so a service must be layer specific.
    /// </summary>
    public interface IPrototypeApplicationService
    {
        /// <summary>Creates the sample entity.</summary>
        /// <param name="name">The name.</param>
        public void CreateSampleEntity(string name);

        /// <summary>Creates the sample entity.</summary>
        /// <param name="dto">The dto.</param>
        public void CreateSampleEntity(SampleEntityDto dto);

        /// <summary>
        ///     Gets the sample entity.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public SampleEntity GetSampleEntity(int i);

        /// <summary>
        ///     Gets all sample entities.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SampleEntityDto> GetAllSampleEntities();

        /// <summary>
        ///     Searches the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public IEnumerable<SampleEntitySelectResult> SearchEntitiesByText(string text);

        /// <summary>
        ///     Removes the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void RemoveEntity(SampleEntityDto entity);
    }
}