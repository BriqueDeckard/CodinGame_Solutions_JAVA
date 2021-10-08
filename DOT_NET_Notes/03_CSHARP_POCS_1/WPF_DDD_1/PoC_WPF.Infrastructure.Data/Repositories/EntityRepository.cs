// -----------------------------------------------------------------------
//  <copyright file="EntityRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace PoC_WPF.Infrastructure.Data.Repositories
{
    using PoC_WPF.Domain;
    using PoC_WPF.Domain.Aggregates;

    public class EntityRepository : GenericRepository<EntityClass>
    {
        public EntityRepository(IUnitOfWork context) : base(context)
        { }
    }
}