using System;
using System.Collections.Generic;
using System.Linq;
using Prototype.ApplicationServices.Contracts;
using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.Dtos;
using Prototype.Domain.Contracts.Mappers;
using Prototype.Domain.Contracts.SeedWork;
using Prototype.Domain.SelectBuilders;
using Prototype.Domain.Specification;
using Prototype.DomainServices.Contracts;

namespace Prototype.ApplicationServices
{
    /// <summary>
    ///     Implementation for Application Services
    /// </summary>
    /// <seealso cref="Prototype.ApplicationServices.Contracts.IPrototypeApplicationService" />
    public class PrototypeApplicationService : IPrototypeApplicationService
    {
        /// <summary>
        ///     The generic repository
        /// </summary>
        private readonly IRepository _genericRepository;

        /// <summary>
        ///     The mapper
        /// </summary>
        private readonly IMapper<SampleEntity, SampleEntityDto> _mapper;

        /// <summary>
        ///     The sample entity domain service
        /// </summary>
        private readonly ISampleEntityDomainService _sampleEntityDomainService;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="domainService"></param>
        public PrototypeApplicationService(IRepository repository, ISampleEntityDomainService domainService,
            ISampleEntityMapper<SampleEntity> mapper)
        {
            if (mapper == null) throw new ArgumentNullException(nameof(mapper));
            Console.WriteLine("\nPrototypeApplicationService : Initialize ApplicationServices for prototype ...");
            _genericRepository = repository;
            _sampleEntityDomainService = domainService;
            _mapper = mapper;
            Console.WriteLine("PrototypeApplicationService : ... ApplicationService initialized.");
        }

        /// <summary>
        ///     Create a sample entity
        /// </summary>
        /// <param name="name"></param>
        public void CreateSampleEntity(string name)
        {
            Console.WriteLine("\nPrototypeApplicationService : Create sample entity ...");
            // Get a new entity
            var entity = _sampleEntityDomainService.GetANewEntity(name, 15);
            Console.WriteLine("\nPrototypeApplicationService : Got entity " + entity.GetType().Name + " with value : " +
                              entity.StringValue);


            // Add entity by using the repository
            Console.WriteLine("\nPrototypeApplicationService : Add entity by using repository ...");
            _genericRepository.AddEntity(entity);

            Console.WriteLine("PrototypeApplicationService : Inserted.");
            Console.WriteLine("PrototypeApplicationService : ... sample entity created");
        }

        /// <summary>
        ///     Creates the sample entity.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <exception cref="System.ArgumentNullException">dto</exception>
        public void CreateSampleEntity(SampleEntityDto dto)
        {
            Console.WriteLine("\nPrototypeApplicationService : Create sample entity from DTO : {0}", dto.StringValue);
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            _sampleEntityDomainService.GetTheEntityPriceLog(dto, 2);

            _genericRepository.AddEntity(_mapper.DtoToEntity(dto));
        }

        /// <summary>
        ///     Gets the sample entity.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public SampleEntity GetSampleEntity(int i)
        {
            Console.WriteLine("\nPrototypeApplicationService : Get sample entity ...");
            var entity = _genericRepository.GetEntity<SampleEntity>(1);
            return entity;
        }

        /// <summary>
        ///     Gets all sample entities.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SampleEntityDto> GetAllSampleEntities()
        {
            Console.WriteLine("\nPrototypeApplicationService : Get all sample entities ...");
            var entities = _genericRepository.GetAll<SampleEntity>();

            return entities.AsEnumerable().Select(x => _mapper.EntityToDto(x));
        }


        /// <summary>
        ///     Searches the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public IEnumerable<SampleEntitySelectResult> SearchEntitiesByText(string text)
        {
            Console.WriteLine("\nPrototypeApplicationService : SearchEntitiesByText sample entities ...");
            var results = _genericRepository.GetByFilter(
                SampleEntitySelectBuilder.SampleEntitySearchSelection(),
                SampleEntitySpecification.Search(text),
                o => o.StringValue, true
            );
            return results;
        }

        /// <inheritdoc />
        public void RemoveEntity(SampleEntityDto dto)
        {
            Console.WriteLine("PrototypeApplicationService : Remove sample entity {0} : {1}", dto.PriceValue,
                dto.StringValue);
            // Converting the entity
            var entity = _mapper.DtoToEntity(dto);
            if (entity == null) throw new ArgumentException(nameof(dto));

            var deleted = _genericRepository.RemoveEntity(entity);
            Console.WriteLine("PrototypeApplicationService : " + (deleted ? "Deleted" : "Not deleted"));
        }
    }
}