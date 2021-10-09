// -----------------------------------------------------------------------
//  <copyright file="PoC_Context.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using PoC_WPF.Domain.Aggregates;

namespace PoC_WPF.Infrastructure.Data.UnitOfWork
{
    using System.Data.Entity;
    using PoC_WPF.Domain;

    //TODO : WPF5.4 Create the Context that inherits from EF DbContext and implements IUnitOfWork
    public class PoC_Context : DbContext, IUnitOfWork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoC_Context"/> class.
        /// </summary>
        public PoC_Context()
                                : base("PoC_WPFConnectionString")
        {
        }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        public IDbSet<EntityClass> Entities { get; set; }

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
                //TODO: LOG
            }
        }

        /// <summary>
        /// Commits the and refresh changes.
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
                    //TODO : LOG
                    valid = false;
                }
            }
        }

        /// <summary>
        /// Rollbacks this instance.
        /// </summary>
        public void Rollback()
        {
            this.ChangeTracker.Entries()
                .ToList() // Cleans the change tracker. The ForEach only exists on the ToList.
                .ForEach(entry => entry.State = EntityState.Unchanged);
        }

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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EntityClass>()
                .HasIndex(i => i.Reference);
        }
    }
}