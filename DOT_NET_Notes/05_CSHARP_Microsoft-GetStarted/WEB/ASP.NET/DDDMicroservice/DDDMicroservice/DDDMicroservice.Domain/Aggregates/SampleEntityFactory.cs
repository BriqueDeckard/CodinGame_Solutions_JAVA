// -----------------------------------------------------------------------
//  <copyright file="SampleEntityFactory.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using DDDMicroservice.Domain.ObjectValue;

namespace DDDMicroservice.Domain.Aggregates
{
    using System;
    using DDDMicroservice.ApplicationService.Contract;

    /// <summary>
    /// SampleEntityFactory class.
    /// </summary>
    public class SampleEntityFactory : ISampleEntityFactory
    {
        /// <summary>
        /// Converts a dto into an entity.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public SampleEntity ConvertADtoIntoAnEntity(SampleEntityDto dto)
        {
            return dto == null
                ? throw new ArgumentNullException()
                : new SampleEntity()
                {
                    BooleanProperty = dto.BooleanProperty,
                    Id = dto.Id,
                    NumberProperty = dto.NumberProperty,
                    StringProperty = dto.StringProperty,
                    ObjectValue = new SampleObjectValue(dto.ObjectValueProperty)
                };
        }

        /// <summary>
        /// Converts an entity into a dto.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public SampleEntityDto ConvertAnEntityIntoADto(SampleEntity entity)
        {
            return entity == null
                ? throw new ArgumentNullException()
                : new SampleEntityDto()
                {
                    BooleanProperty = entity.BooleanProperty,
                    Id = entity.Id,
                    NumberProperty = entity.NumberProperty,
                    StringProperty = entity.StringProperty,
                    ObjectValueProperty = entity.ObjectValue?.StringProperty
                };
        }
    }
}