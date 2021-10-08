// -----------------------------------------------------------------------
//  <copyright file="SampleApplicationService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using DDDMicroservice.Infrastructure.Data.UnitOfWork.Repositories;

namespace DDDMicroservice.ApplicationService
{
    using System;
    using System.Linq;
    using System.Data;

    using DDDMicroservice.Domain.Aggregates;
    using DDDMicroservice.Infrastructure.Data.UnitOfWork;

    using System.Collections.Generic;
    using DDDMicroservice.ApplicationService.Contract;

    /// <inheritdoc />
    public class SampleApplicationService : ISampleApplicationService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleApplicationService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public SampleApplicationService(ISampleRepository repository, ISampleEntityFactory factory)
        {
            this._repository = repository;
            this._factory = factory;
        }

        /// <summary>
        /// Adds the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        /// <exception cref="DataException"></exception>
        public SampleEntityDto Add(SampleEntityDto dto)
        {
            SampleEntity entity = this._factory.ConvertADtoIntoAnEntity(dto);

            if (entity == null)
            {
                throw new Exception("No converted entity");
            }

            SampleEntity resultEntity = this._repository.AddEntity(entity);
            if (resultEntity == null)
            {
                throw new Exception("No result entity");
            }

            SampleEntityDto resultDto = this._factory.ConvertAnEntityIntoADto(resultEntity);

            if (resultDto == null)
            {
                throw new Exception("No result dto");
            }

            return resultDto;
        }

        /// <summary>
        /// Deletes the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">No converted entity</exception>
        public SampleEntityDto Delete(SampleEntityDto dto)
        {
            SampleEntity entity = this._factory.ConvertADtoIntoAnEntity(dto);

            if (entity == null)
            {
                throw new Exception("No converted entity");
            }
            SampleEntity resultEntity;
            try
            {
                resultEntity = this._repository.RemoveEntity(entity);
                return _factory.ConvertAnEntityIntoADto(resultEntity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public string Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException();
            }

            string resultId;
            try
            {
                resultId = this._repository.RemoveEntity(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return resultId;
        }

        /// <summary>
        /// Searches the specified search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public SampleEntityDto Search(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return null;
            }
            return this.Search().Where(s => s.Id == searchText)?.FirstOrDefault();
        }

        /// <summary>
        /// Searches this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SampleEntityDto> Search()
        {
            return this._repository.SearchEntity()?.Select(this._factory.ConvertAnEntityIntoADto);
        }

        /// <summary>
        /// The factory
        /// </summary>
        private readonly ISampleEntityFactory _factory;

        /// <summary>
        /// The repository
        /// </summary>
        private readonly ISampleRepository _repository;
    }
}