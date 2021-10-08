// -----------------------------------------------------------------------
//  <copyright file="ISampleRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Collections.Generic;
using DDDMicroservice.Domain.Aggregates;

namespace DDDMicroservice.Infrastructure.Data.UnitOfWork.Repositories
{
    /// <summary>
    /// Interface for GenericRepository class.
    /// </summary>
    public interface ISampleRepository
    {
        /// <summary>
        /// Adds the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        SampleEntity AddEntity(SampleEntity entity);

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <param name="sampleEntityIn">The sample entity in.</param>
        SampleEntity RemoveEntity(SampleEntity sampleEntityIn);

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        string RemoveEntity(string id);

        /// <summary>
        /// Searches the entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        SampleEntity SearchEntity(string id);

        /// <summary>
        /// Searches the entity.
        /// </summary>
        /// <returns></returns>
        IEnumerable<SampleEntity> SearchEntity();

        /// <summary>
        /// Updates the entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="sampleEntityIn">The sample entity in.</param>
        void UpdateEntity(string id, SampleEntity sampleEntityIn);
    }
}