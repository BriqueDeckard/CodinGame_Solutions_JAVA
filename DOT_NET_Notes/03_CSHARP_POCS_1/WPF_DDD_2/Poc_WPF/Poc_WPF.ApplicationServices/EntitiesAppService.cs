// -----------------------------------------------------------------------
//  <copyright file="EntitiesAppService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Collections.Generic;
using Poc_WPF.ApplicationServices.Contracts.Dtos;
using Poc_WPF.Domain;

namespace Poc_WPF.ApplicationServices
{
    using System;
    using Poc_WPF.ApplicationServices.Contracts;
    using Poc_WPF.Infrastructure.Data.UnitOfWork;

    /// <summary>
    /// App service for Entities.
    /// </summary>
    /// <seealso cref="Poc_WPF.ApplicationServices.Contracts.IEntitiesAppService" />
    public class EntitiesAppService : IEntitiesAppService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesAppService"/> class.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="repository">The repository.</param>
        public EntitiesAppService(IFactory factory, IRepository repository)
        {
            _factory = factory;
            _repository = repository;
        }

        /// <summary>
        /// Adds the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public bool Add(EntityDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }

            return this._repository.Add(this._factory.DtoToEntity(dto));
        }

        /// <summary>
        /// Searches the specified search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        public IList<EntitySearchDto> Search(string searchText)
        {
            var results = this._repository.GetEntity<Entity>(001, null);
            if (results == null)
            {
                return new List<EntitySearchDto>();
            }

            var searchDto = new EntitySearchDto { Body = results.Body, Id = results.Id };

            return new List<EntitySearchDto> { searchDto };
        }

        /// <summary>
        /// The factory
        /// </summary>
        private readonly IFactory _factory;

        /// <summary>
        /// The repository
        /// </summary>
        private readonly IRepository _repository;
    }
}