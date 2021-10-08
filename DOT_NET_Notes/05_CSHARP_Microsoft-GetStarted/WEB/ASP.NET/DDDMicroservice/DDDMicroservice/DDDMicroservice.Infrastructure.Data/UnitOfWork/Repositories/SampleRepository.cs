// -----------------------------------------------------------------------
//  <copyright file="SampleRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using DDDMicroservice.Domain;
using DDDMicroservice.Domain.Aggregates;
using MongoDB.Driver;

namespace DDDMicroservice.Infrastructure.Data.UnitOfWork.Repositories
{
    /// <summary>
    /// SampleRepository class.
    /// </summary>
    /// <seealso cref="ISampleRepository" />
    public class SampleRepository : ISampleRepository
    {
        /// <summary>
        /// The sample entities
        /// </summary>
        public IMongoCollection<SampleEntity> SampleEntities;

        public SampleRepository()
        {
            MongoClient client = new MongoClient(this._settings.ConnectionString);

            IMongoDatabase database = client.GetDatabase(this._settings.DatabaseName);

            this.SampleEntities = database.GetCollection<SampleEntity>(this._settings.SampleCollectionName);
        }

        /// <summary>
        /// Adds the entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public SampleEntity AddEntity(SampleEntity sampleEntityIn)
        {
            if (sampleEntityIn == null)
            {
                throw new ArgumentNullException();
            }

            SampleEntities.InsertOne(sampleEntityIn);
            return sampleEntityIn;
        }

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <param name="sampleEntityIn">The sample entity in.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SampleEntity RemoveEntity(SampleEntity sampleEntityIn)
        {
            if (sampleEntityIn == null)
            {
                throw new ArgumentNullException();
            }

            SampleEntities.DeleteOne(entity => entity.Id == sampleEntityIn.Id);

            return sampleEntityIn;
        }

        /// <summary>
        /// Removes the entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public string RemoveEntity(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException();
            }

            SampleEntities.DeleteOne(entity => entity.Id.Equals(id));

            return id;
        }

        /// <summary>
        /// Searches the entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public SampleEntity SearchEntity(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException();
            }

            return this.SampleEntities.Find<SampleEntity>(entity => entity.Id.Equals(id)).FirstOrDefault();
        }

        /// <summary>
        /// Searches the entity.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SampleEntity> SearchEntity()
        {
            return SampleEntities.Find(entity => true).ToList();
        }

        /// <summary>
        /// Updates the entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="sampleEntityIn">The sample entity in.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void UpdateEntity(string id, SampleEntity sampleEntityIn)
        {
            if (string.IsNullOrEmpty(id) || sampleEntityIn == null)
            {
                throw new ArgumentNullException();
            }

            SampleEntities.ReplaceOne(entity => entity.Id.Equals(id), sampleEntityIn);
        }

        private readonly SampleDatabaseSettings _settings = ConfigurationManager.SampleDb;
    }
}