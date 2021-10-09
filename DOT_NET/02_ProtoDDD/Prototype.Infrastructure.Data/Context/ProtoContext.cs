using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Infrastructure.Data.Context
{
    /// <summary>
    ///     Database EFCore context for Prototype application
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    /// <seealso cref="System.IDisposable" />
    /// <seealso cref="Prototype.Domain.Contracts.SeedWork.IUnitOfWork" />
    public class ProtoContext : DbContext, IDisposable, IUnitOfWork
    {
        #region EntityFrameworkSettings

        /// <summary>
        ///     Gets or sets the sample entities.
        /// </summary>
        /// <value>
        ///     The sample entities.
        /// </value>
        public DbSet<SampleEntity> SampleEntities { get; set; }

        #endregion


        /// <summary>
        ///     Override this method to further configure the model that was discovered by convention from the entity types
        ///     exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting
        ///     model may be cached
        ///     and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">
        ///     The builder being used to construct the model for this context. Databases (and other extensions) typically
        ///     define extension methods on this object that allow you to configure aspects of the model that are specific
        ///     to a given database.
        /// </param>
        /// <remarks>
        ///     If a model is explicitly set on the options for this context (via
        ///     <see
        ///         cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />
        ///     )
        ///     then this method will not be run.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        ///     <para>
        ///         Override this method to configure the database (and other options) to be used for this context.
        ///         This method is called for each instance of the context that is created.
        ///         The base implementation does nothing.
        ///     </para>
        ///     <para>
        ///         In situations where an instance of <see cref="T:Microsoft.EntityFrameworkCore.DbContextOptions" /> may or may
        ///         not have been passed
        ///         to the constructor, you can use
        ///         <see cref="P:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured" /> to determine if
        ///         the options have already been set, and skip some or all of the logic in
        ///         <see
        ///             cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" />
        ///         .
        ///     </para>
        /// </summary>
        /// <param name="optionsBuilder">
        ///     A builder used to create or modify options for this context. Databases (and other extensions)
        ///     typically define extension methods on this object that allow you to configure the context.
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
            optionsBuilder.UseNpgsql(@"host=localhost;database=PrototypeDDD;user id=postgres;password=6845;");
        }

        #region Implemented UnitOfWork

        /// <summary>
        ///     Asynchronouses the commit.
        /// </summary>
        /// <returns></returns>
        public async Task<int> DoAsyncCommit()
        {
            return await SaveChangesAsync();
        }

        /// <summary>
        ///     Commits this instance.
        /// </summary>
        public void Commit()
        {
            SaveChanges();
        }

        /// <summary>
        ///     Rollbacks this instance.
        /// </summary>
        public void Rollback()
        {
            ChangeTracker.Entries()
                .ToList() // Cleans the change tracker
                .ForEach(entry => entry.State = EntityState.Unchanged);
        }

        #endregion
    }
}