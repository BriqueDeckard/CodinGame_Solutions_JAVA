// -----------------------------------------------------------------------
//  <copyright file="IFirebaseMessage.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService.Contract
{
    /// <summary>
    /// Interface that ensures the Message is "pushable".
    /// Words start with lowercase because of the Firebase requirement.
    /// </summary>
    public interface IFirebaseMessage
    {
        /// <summary>
        /// Gets or sets a value indicating whether [content available].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [content available]; otherwise, <c>false</c>.
        /// </value>
        bool content_available { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        object data { get; set; }

        /// <summary>
        /// Gets or sets the notification.
        /// </summary>
        /// <value>
        /// The notification.
        /// </value>
        IFirebaseNotification notification { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        string priority { get; set; }

        /// <summary>
        /// Gets or sets the recipient.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        string to { get; set; }
    }
}