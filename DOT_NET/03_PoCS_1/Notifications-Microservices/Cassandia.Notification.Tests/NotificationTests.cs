// -----------------------------------------------------------------------
//  <copyright file="NotificationTests.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace Cassandia.Notification.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Cassandia.ApplicationService.Contract.Core;
    using Cassandia.ApplicationService.Contract.Core.Mappers;
    using Cassandia.Domain.Core.Factories;
    using Cassandia.Domain.Core.Specification;
    using Cassandia.Infrastructure.Data.Core;
    using Cassandia.Notification.ApplicationService.Contract;
    using Cassandia.Notification.Infrastructure.IoC;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;
    using Cassandia.Notification.Infrastructure.Data;
    using Cassandia.Tests.Core;
    using Domain.Aggregates;

    /// <summary>
    /// Test class for Notification micro-service.
    /// </summary>
    /// <seealso cref="Cassandia.Tests.Core.CassandiaTest{Cassandia.Notification.Domain.Aggregates.CassandiaNotification}" />
    public class NotificationTests : CassandiaTest<CassandiaNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTests"/> class.
        /// </summary>
        public NotificationTests()
        {
            this._repository = this.Provider.GetService<IObjectRepository<CassandiaNotification>>();
            this._factory = this.Provider.GetService<IFactory<CassandiaNotification, CassandiaNotificationDto, string>>();
            this._business = this.Provider
                .GetService<IBusinessSpecification<CassandiaNotification, NotificationParameterDto, string>>();
            this._mapper = this.Provider.GetService<IMapper<CassandiaNotification>>();
            this._applicationService = this.Provider
                .GetService<ICoreApplicationService<CassandiaNotificationDto, NotificationParameterDto, string>>();
            this._notificationApplicationService = this.Provider.GetService<INotificationApplicationService>();
        }

        /// <summary>
        /// Tests the add dto notification.
        /// </summary>
        [Fact]
        public void test_Add_Dto_Notification()
        {
            // Creation of a dto
            var dto = new CassandiaNotificationDto()
            {
                Body = "TestBody",
                ContentAvailable = true,
                Priority = "high",
                Title = "TestTitle",
                Topic = "TestTopic"
            };

            //Add dto to the database
            this._applicationService.Add(dto);

            //Parameter with no filter
            NotificationParameterDto parameterDto = new NotificationParameterDto();

            //Gets dto from database
            IEnumerable<CassandiaNotificationDto> data = this._applicationService.GetSearch(parameterDto).ToList();

            //Check data contains only one entity
            Assert.Single(data);

            // Gets the entity.
            CassandiaNotificationDto entity = data.ElementAt(0);

            //Checks entity ID is not null, not empty and without whitespaces
            Assert.True(!string.IsNullOrEmpty(entity.Id.ToString()) && !string.IsNullOrWhiteSpace(entity.Id.ToString()));

            //Checks dto is equal to entity
            Assert.Equal(entity.Title, dto.Title);
            Assert.Equal(entity.Body, dto.Body);
            Assert.Equal(entity.ContentAvailable, dto.ContentAvailable);
            Assert.Equal(entity.Priority, dto.Priority);
            Assert.Equal(entity.Topic, ("/topics/" + dto.Topic));
        }

        /// <summary>
        /// Tests the dto to notification entity.
        /// </summary>
        [Fact]
        public void Test_Dto_To_NotificationEntity()
        {
            // Create Notification dto
            var dto = new CassandiaNotificationDto()
            {
                Body = "MyBody",
                ContentAvailable = true,
                Title = "MyTitle",
                Topic = "MyTopic",
                Priority = "MyPriority",
                Id = "MyId"
            };

            var entity = _factory.DtoToEntity(dto);

            Assert.Equal(dto.Body, entity.Message.notification.body);
            Assert.Equal(dto.ContentAvailable, entity.Message.content_available);
            Assert.Equal(dto.Title, entity.Message.notification.title);
            Assert.Equal("/topics/" + dto.Topic, entity.Message.to);
            Assert.Equal(dto.Priority, entity.Message.priority);
            Assert.Equal(dto.Id, entity.Id);
        }

        /// <summary>
        /// Tests the entity to notification dto.
        /// </summary>
        [Fact]
        public void Test_Entity_To_NotificationDto()
        {
            // Create Notification entity
            CassandiaNotification entity = new CassandiaNotification()
            {
                Id = "123456",
                Message = new Message()
                {
                    content_available = true,
                    priority = "high",
                    to = "topic",
                    notification = new FirebaseNotification()
                    {
                        body = "body",
                        title = "title"
                    }
                }
            };

            // Convert the entity to a Notification dto
            CassandiaNotificationDto dto = _factory.EntityToDto(entity);
            //Checks entity gets id not null, not empty and without whitespaces
            Assert.True(!string.IsNullOrEmpty(entity.Id.ToString()) && !string.IsNullOrWhiteSpace(entity.Id.ToString()));
            // Checks entity corresponds to the dto
            Assert.Equal(entity.Message.notification.title, dto.Title);
            Assert.Equal(entity.Message.notification.body, dto.Body);
            Assert.Equal(entity.Message.content_available, dto.ContentAvailable);
            Assert.Equal(entity.Message.priority, dto.Priority);
            Assert.Equal(entity.Message.to, dto.Topic);
        }

        /// <summary>
        /// Tests the get with filter.
        /// </summary>
        [Fact]
        public void Test_GetWithFilter()
        {
            //Adding notification to database
            CassandiaNotificationDto dto1 = new CassandiaNotificationDto()
            {
                Body = "MyBody",
                Title = "Title1",
                Topic = "Topic1"
            };
            CassandiaNotificationDto dto2 = new CassandiaNotificationDto()
            {
                Body = "MyBody",
                Title = "Title2",
                Topic = "Topic2"
            };
            CassandiaNotificationDto dto3 = new CassandiaNotificationDto()
            {
                Body = "MyBody",
                Title = "Title3",
                Topic = "Topic3"
            };

            _applicationService.Add(dto1);
            _applicationService.Add(dto2);
            _applicationService.Add(dto3);

            NotificationParameterDto parameterdto = new NotificationParameterDto();

            IEnumerable<CassandiaNotificationDto> data1 = this._applicationService.GetSearch(parameterdto);
            Assert.Equal(3, data1.Count());

            NotificationParameterDto parameterWithTitle = new NotificationParameterDto()
            {
                Title = "Title1"
            };

            IEnumerable<CassandiaNotificationDto> data2 = this._applicationService.GetSearch(parameterWithTitle);
            Assert.Single(data2);

            NotificationParameterDto parameterWithTopic = new NotificationParameterDto()
            {
                Topic = "Topic3"
            };

            IEnumerable<CassandiaNotificationDto> data3 = this._applicationService.GetSearch(parameterWithTopic);
            Assert.Single(data3);
        }

        /// <summary>
        /// Injects the services.
        /// </summary>
        /// <param name="services">The services.</param>
        protected override void InjectServices(IServiceCollection services)
        {
            services.AddScoped<INotificationRepository, NotificationMockRepository>();
            NotificationInjector.InjectServices(services);
        }

        protected override void LoadDatas()
        {
        }

        /// <summary>
        /// The application service
        /// </summary>
        private ICoreApplicationService<CassandiaNotificationDto, NotificationParameterDto, string> _applicationService;

        /// <summary>
        /// The business specification
        /// </summary>
        private IBusinessSpecification<CassandiaNotification, NotificationParameterDto, string> _business;

        /// <summary>
        /// The factory
        /// </summary>
        private IFactory<CassandiaNotification, CassandiaNotificationDto, string> _factory;

        /// <summary>
        /// The mapper
        /// </summary>
        private IMapper<CassandiaNotification> _mapper;

        /// <summary>
        /// The notification application service
        /// </summary>
        private INotificationApplicationService _notificationApplicationService;

        /// <summary>
        /// The repository
        /// </summary>
        private IObjectRepository<CassandiaNotification> _repository;
    }
}