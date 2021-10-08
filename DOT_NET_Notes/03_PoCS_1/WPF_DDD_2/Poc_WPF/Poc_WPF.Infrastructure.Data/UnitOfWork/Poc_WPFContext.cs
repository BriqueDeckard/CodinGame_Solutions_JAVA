// -----------------------------------------------------------------------
//  <copyright file="Poc_WPFContext.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.Infrastructure.Data.UnitOfWork
{
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Poc_WPF.Domain;

    /// <summary>
    /// Database context for app.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    /// <seealso cref="Poc_WPF.Domain.IUnitOfWork" />
    public class Poc_WPFContext : DbContext, IUnitOfWork
    {
        public Poc_WPFContext()
        : base("PocContext")
        {
        }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        public DbSet<Entity> Entities { get; set; }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
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
        /// Commits the and refresh changes.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
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

        /// <summary>
        /// Rollbacks the changes.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Rollback()
        {
            throw new System.NotImplementedException();
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
            modelBuilder.Entity<Entity>()
                .HasIndex(i => i.reference);
        }

        //private static string connectionString = "Data Source = Localhost; Initial Catalog = wpf_test_db; user id = pierre; password=2019";
    }
}