// -----------------------------------------------------------------------
//  <copyright file="ConfigurationManager.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.Infrastructure.Data.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Configuration manager for notification pushing.
    /// </summary>
    public static class ConfigurationManager
    {
        /// <summary>
        /// Binds the notification settings.
        /// </summary>
        /// <returns></returns>
        public static NotificationSettings BindNotificationSettings()
        {
            NotificationSettings settings = ConfigurationBinder.Get<NotificationSettings>(Configuration);
            string current = Directory.GetCurrentDirectory();

            ConfigurationBinder.Bind(Configuration.GetSection("Notification"), settings);

            return settings;
        }

        /// <summary>
        /// Gets the notification settings.
        /// </summary>
        /// <value>
        /// The notification settings.
        /// </value>
        internal static NotificationSettings NotificationSettings => BindNotificationSettings();

        /// <summary>
        /// The configuration
        /// </summary>
        private static IConfigurationRoot Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();
    }
}