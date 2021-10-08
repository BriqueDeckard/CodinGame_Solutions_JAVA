using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype.Domain.Contracts.SeedWork
{
    /// <summary>
    ///     Abstract class for entity.
    /// </summary>
    /// <seealso cref="Prototype.Domain.Contracts.SeedWork.IEntity" />
    /// <seealso cref="Prototype.Domain.Contracts.SeedWork.IAggregateRoot" />
    public abstract class Entity : IEntity, IAggregateRoot
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}