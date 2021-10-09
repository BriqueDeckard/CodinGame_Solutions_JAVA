namespace Prototype.Domain.Contracts.SeedWork
{
    /// <summary>
    ///     Interface for a factory
    /// </summary>
    /// <typeparam name="TE"></typeparam>
    /// <typeparam name="TD"></typeparam>
    public interface IMapper<TE, TD> where TE : Entity
    {
        /// <summary>
        ///     Dtos to entity conversion.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        TE DtoToEntity(TD dto);

        /// <summary>
        ///     Entities to dto conversion.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        TD EntityToDto(TE entity);
    }
}