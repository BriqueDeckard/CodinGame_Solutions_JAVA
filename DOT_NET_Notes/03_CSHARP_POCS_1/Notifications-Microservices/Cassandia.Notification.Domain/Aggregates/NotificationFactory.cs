//-----------------------------------------------------------------------
// <copyright file="NotificationFactory.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Domain.Aggregates
{
    using System.Collections.Generic;
    using System.Linq;
    using Cassandia.Domain.Core.Factories;
    using Cassandia.Notification.ApplicationService.Contract;
    using MongoDB.Bson;

    /// <summary>
    /// A Factory to work with Notification entity and Dto
    /// </summary>
    public class NotificationFactory : IFactory<CassandiaNotification, CassandiaNotificationDto, string>
    {
        /// <summary>
        /// Transforms a Notification DTO into an Entity
        /// </summary>
        /// <param name="dto">
        /// The dto to transform
        /// </param>
        /// <returns>
        /// The corresponding Entity
        /// </returns>
        public CassandiaNotification DtoToEntity(CassandiaNotificationDto dto)
        {
            if (dto != null)
            {
                /*
                // Creates a Firebase message that encapsulate the Firebase notification
                IFirebaseMessage firebaseMessage = new Message()
                {
                    content_available = dto.Message.ContentAvailable,
                    priority = dto.Message.Priority,
                    data = dto.Message.Data,
                    notification = new FirebaseNotification()
                    {
                        body = dto.Message.Notification.Body,
                        title = dto.Message.Notification.Title
                    }
                };
                */
                string topic = "";

                if (!string.IsNullOrEmpty(dto.Topic))
                {
                    topic = "/topics/" + dto.Topic;
                }

                //Creates a Notification mongo entity that encapsulate the message
                CassandiaNotification cassandiaNotification = new CassandiaNotification()
                {
                    Id = dto.Id,
                    Message = new Message()
                    {
                        content_available = dto.Message.ContentAvailable,
                        priority = dto.Message.Priority,
                        data = dto.Message.Data,
                        to = topic,
                        notification = new FirebaseNotification()
                        {
                            body = dto.Message.Notification.Body,
                            title = dto.Message.Notification.Title
                        }
                    }
                };

                return cassandiaNotification;
            }

            return new CassandiaNotification();
        }

        /// <summary>
        /// Transforms the given entities into dtos.
        /// </summary>
        /// <param name="entities">
        /// Entities to transform
        /// </param>
        /// <returns>
        /// The corresponding Dtos
        /// </returns>
        public IEnumerable<CassandiaNotificationDto> EntitiesToDtos(IEnumerable<CassandiaNotification> entities)
        {
            return entities.Select(this.EntityToDto);
        }

        /// <summary>
        /// Converts an entity into dto
        /// </summary>
        /// <param name="entity">
        /// The entity to convert
        /// </param>
        /// <returns>
        /// The dto from converted entity
        /// </returns>
        public CassandiaNotificationDto EntityToDto(CassandiaNotification entity)
        {
            CassandiaNotificationDto dto = new CassandiaNotificationDto();

            //Checks if there is an entity.
            if (entity == null)
            {
                return dto;
            }

            //Sets the dto id.
            dto.Id = (!string.IsNullOrEmpty(entity.Id)) ? entity.Id : ObjectId.GenerateNewId().ToString();

            //If there isn't no message, return the dto.
            if (entity.Message == null)
            {
                return dto;
            }

            dto.Topic = (!string.IsNullOrEmpty(entity.Message.to)) ? entity.Message.to : "";

            //dto.Message

            //If there isn't no notification, return the dto.
            if (entity.Message.notification == null)
            {
                return dto;
            }

            //Creates a firebase notification dto
            FirebaseNotificationDto firebaseNotificationDto = new FirebaseNotificationDto()
            {
                Body = entity.Message.notification.body,
                Title = entity.Message.notification.title
            };

            //Creates a firebase message dto with that notification.
            FirebaseMessageDto firebaseMessageDto = new FirebaseMessageDto()
            {
                ContentAvailable = entity.Message.content_available,
                Notification = firebaseNotificationDto,
                Priority = (!string.IsNullOrEmpty(entity.Message.priority)) ? entity.Message.priority : "normal",
                Data = entity.Message.data
            };

            // Set the cassandia dto message dto .
            dto.Message = firebaseMessageDto;

            return dto;
        }

        public void UpdateEntity(CassandiaNotification entity, CassandiaNotificationDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}