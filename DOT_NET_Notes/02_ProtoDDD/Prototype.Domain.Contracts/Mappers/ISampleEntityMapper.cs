using Prototype.Domain.Contracts.Dtos;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Contracts.Mappers
{
    /// <summary>
    ///     Interface for Sample entity mapper
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public interface ISampleEntityMapper<TE> : IMapper<TE, SampleEntityDto> where TE : Entity
    {
    }
}