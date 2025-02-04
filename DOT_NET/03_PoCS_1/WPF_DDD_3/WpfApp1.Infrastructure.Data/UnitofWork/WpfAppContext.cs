﻿// -----------------------------------------------------------------------
//  <copyright file="WpfAppContext.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace WpfApp1.Infrastructure.Data.UnitofWork
{
    using System;
    using System.Data.Entity;

    using WpfApp1.Domain;

    public class WpfAppContext : DbContext, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfAppContext"/> class.
        /// </summary>
        public WpfAppContext()
            : base("WpfAppConnectionString")
        {
            //Database.SetInitializer<WpfAppContext>(new MigrateDatabaseToLatestVersion<WpfAppContext, Migrations.Configuration>());

#if DEBUG

#endif
        }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// the products.
        /// </value>
        public IDbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the product prices.
        /// </summary>
        /// <value>
        /// the product prices.
        /// </value>
        public IDbSet<ProductPrice> ProductPrices { get; set; }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuilder, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .HasIndex(i => i.Reference);
        }
    }
}