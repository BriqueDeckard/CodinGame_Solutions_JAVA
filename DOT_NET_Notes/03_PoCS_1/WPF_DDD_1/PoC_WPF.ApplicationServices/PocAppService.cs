// -----------------------------------------------------------------------
//  <copyright file="PocAppService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace PoC_WPF.ApplicationServices
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using PoC_WPF.ApplicationServices.Contracts;
    using PoC_WPF.Domain.Aggregates;
    using PoC_WPF.Infrastructure.Data.UnitOfWork;

    //TODO : WPF 6.2 Create AppService class
    public class PocAppService : IPocAppService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PocAppService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public PocAppService(IRepository<EntityClass> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Adds this object.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public EntityClass Add()
        {
            EntityClass o = new EntityClass()
            {
                CreationDate = DateTime.Now,
                IsActivated = true,
                Name = "myName",
                Reference = "01",
                Id = 01
            };
            this._repository.Add(o);
            return o;
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public EntityClass Get(int id)
        {
            EntityClass aa = this._repository.GetById(id);
            if (aa == null)
            {
                return new EntityClass() { Name = "null" };
            }

            return aa;
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        public void initializeData()
        {
            List<EntityClass> list = new List<EntityClass>()
            {
                new EntityClass(){Name = "A"},
                new EntityClass(){Name = "B"},
                new EntityClass(){Name = "C"},
                new EntityClass(){Name = "D"},
                new EntityClass(){Name = "E"}
            };

            foreach (EntityClass entityClass in list)
            {
                this._repository.Add(entityClass);
            }
        }

        /// <summary>
        /// The repository
        /// </summary>
        private readonly IRepository<EntityClass> _repository;
    }
}