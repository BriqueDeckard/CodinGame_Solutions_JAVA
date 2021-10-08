// -----------------------------------------------------------------------
//  <copyright file="POC_PrismContext.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("POC_Prism.Infrastructure.Data.Test")]

namespace POC_Prism.Infrastructure.data.UnitOfWork
{
    using POC_Prism.Domain;

    using System;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    using System.Data.Entity;

    //TODO: UoW 1
    /// <summary>
    /// Data base context for app.
    /// </summary>
    /// Internal : Only available in the assembly.
    /// <seealso cref="System.Data.Entity.DbContext" />

    internal class POC_PrismContext : DbContext, IDisposable, IUnitOfWork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POC_PrismContext"/> class.
        /// </summary>
        public POC_PrismContext()
        : base("PocPrismConnectionString")
        {
#if DEBUG

#endif
        }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public IDbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the product prices.
        /// </summary>
        /// <value>
        /// The product prices.
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
        //TODO : UoW 3
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasIndex(i => i.Reference);
        }

        #region - - - - Implemented UnitOfWork - - - -

        /// <summary>
        /// Rollbacks the changes.
        /// </summary>
        public void Rollback()
        {
            this.ChangeTracker.Entries()
                .ToList() // Cleans the change tracker. The ForEach only exists on the ToList.
                .ForEach(entry => entry.State = EntityState.Unchanged);
        }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            try
            {
                this.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                //TODO : Logger l'exception
                Console.WriteLine(exception);
                throw;
            }
        }

        /// <summary>
        /// Commits and refresh changes.
        /// </summary>
        public void CommitAndRefreshChanges()
        {
            var valid = false;

            while (!valid)
            {
                try
                {
                    this.SaveChanges();
                    valid = true;
                }
                catch (DBConcurrencyException exception)
                {
                    //TODO : Log
                    valid = false;
                }
            }
        }

        #endregion
    }
}