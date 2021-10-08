// -----------------------------------------------------------------------
//  <copyright file="IFirebaseNotification.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService.Contract
{
    /// <summary>
    /// Interface to ensure that we can push the notification by firebase.
    /// </summary>
    public interface IFirebaseNotification
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        string body { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string title { get; set; }
    }
}