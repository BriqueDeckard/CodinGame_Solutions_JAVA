using System;
using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.Dtos;
using Prototype.Domain.Contracts.Mappers;

namespace Prototype.Domain.Mappers
{
    /// <summary>
    ///     Mapper to handle entity to dto and dto to entity conversion.
    /// </summary>
    public class SampleEntityMapper : ISampleEntityMapper<SampleEntity>
    {
        /// <inheritdoc />
        public SampleEntity DtoToEntity(SampleEntityDto dto)
        {
            Console.WriteLine("SampleEntityMapper : Converting dto to entity");
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            return new SampleEntity(dto.StringValue, 0);
        }

        /// <inheritdoc />
        public SampleEntityDto EntityToDto(SampleEntity entity)
        {
            Console.WriteLine("SampleEntityMapper : Converting entity to dto");
            if (entity == null) throw new ArgumentNullException();

            return new SampleEntityDto(entity.StringValue, entity.PriceValue, entity.Id);
        }
    }
}