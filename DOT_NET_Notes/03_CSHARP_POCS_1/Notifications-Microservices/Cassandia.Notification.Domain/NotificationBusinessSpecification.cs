//-----------------------------------------------------------------------
// <copyright file="NotificationBusinessSpecification.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Domain
{
    using Cassandia.Domain.Core.Specification;
    using Cassandia.Notification.ApplicationService.Contract;
    using Aggregates;

    /// <summary>
    /// Micro-service business specification
    /// </summary>
    public class NotificationBusinessSpecification : IBusinessSpecification<CassandiaNotification, NotificationParameterDto, string>
    {
        /// <summary>
        /// Gets the business specification for Notification
        /// </summary>
        /// <param name="parameterDto">
        /// parameters to apply to build business specification
        /// </param>
        /// <returns>
        /// A complete specification
        /// </returns>
        public ISpecification<Aggregates.CassandiaNotification> Get(NotificationParameterDto parameterDto)
        {
            Specification<CassandiaNotification> businessSpec = new TrueSpecification<CassandiaNotification>();

            //Search by topic
            if (!string.IsNullOrEmpty(parameterDto.Topic))
            {
                businessSpec &= new DirectSpecification<CassandiaNotification>(e => e.Message.to == "/topics/" + parameterDto.Topic);
            }

            //Search by title
            if (!string.IsNullOrEmpty(parameterDto.Title))
            {
                businessSpec &= new DirectSpecification<CassandiaNotification>(e => e.Message.notification.title == parameterDto.Title);
            }

            return businessSpec;
        }
    }
}