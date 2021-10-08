// -----------------------------------------------------------------------
//  <copyright file="IUnitOfWork.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;

namespace DDDMicroservice.Infrastructure.Data.UnitOfWork
{
    public interface IUnitOfWork<TContext> : IDisposable
    {
    }
}