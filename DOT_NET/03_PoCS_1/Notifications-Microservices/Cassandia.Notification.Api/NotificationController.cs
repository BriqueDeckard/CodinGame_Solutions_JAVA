//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Api
{
    using Cassandia.Api.Core;
    using Cassandia.Api.Core.Converters;
    using Cassandia.ApiGateway;
    using Cassandia.ApplicationService.Contract.Core;
    using Cassandia.Notification.ApplicationService.Contract;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Notification Controller
    /// </summary>
    [ApiController]
    [KongGateway]
    [Route("[controller]")]
    public class NotificationController : CoreControllerBase<CassandiaNotificationDto, NotificationParameter, NotificationParameterDto, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationController"/> class.
        /// </summary>
        /// <param name="parameterConverter">
        /// The parameter converter.
        /// </param>
        /// <param name="applicationService">
        /// The application service.
        /// </param>
        /// <param name="notificationApplicationService">
        /// The notification application service.
        /// </param>
        public NotificationController(
            IParameterConverter<NotificationParameter, NotificationParameterDto> parameterConverter,
            ICoreApplicationService<CassandiaNotificationDto, NotificationParameterDto, string> applicationService,
            INotificationApplicationService notificationApplicationService) :
            base(parameterConverter, applicationService)
        {
            this._notificationApplicationService = notificationApplicationService;
        }

        /// <summary>
        /// Pushes the notification.
        /// </summary>
        /// <param name="dto">
        /// The dto.
        /// </param>
        /// <returns></returns>
        [Route("push_to_topic")]
        [HttpPost]
        public IActionResult PushToATopic(CassandiaNotificationDto dto)
        {
            string result = this._notificationApplicationService.PushToTopic(dto);

            if (!string.IsNullOrEmpty(result))
                return this.Ok(result);
            return this.BadRequest();
        }

        /// <summary>
        /// The notification application service
        /// </summary>
        private readonly INotificationApplicationService _notificationApplicationService;
    }
}