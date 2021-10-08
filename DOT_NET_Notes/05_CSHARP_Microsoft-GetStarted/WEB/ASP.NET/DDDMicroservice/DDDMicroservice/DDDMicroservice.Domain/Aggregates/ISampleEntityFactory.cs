// -----------------------------------------------------------------------
//  <copyright file="ISampleEntityFactory.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.Domain.Aggregates
{
    using DDDMicroservice.ApplicationService.Contract;

    /// <summary>
    /// Interface for sample entity factory.
    /// </summary>
    public interface ISampleEntityFactory
    {
        /// <summary>
        /// Converts a dto into an entity.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        SampleEntity ConvertADtoIntoAnEntity(SampleEntityDto dto);

        /// <summary>
        /// Converts an entity into a dto.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        SampleEntityDto ConvertAnEntityIntoADto(SampleEntity entity);
    }
}