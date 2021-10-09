// -----------------------------------------------------------------------
//  <copyright file="ConfigurationManager.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.Infrastructure.Data
{
    using System.IO;
    using DDDMicroservice.Domain;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// ConfigurationManager class.
    /// </summary>
    public static class ConfigurationManager
    {
        /// <summary>
        /// Gets the sample database.
        /// </summary>
        /// <value>
        /// The sample database.
        /// </value>
        internal static SampleDatabaseSettings SampleDb => BindDatabaseConfiguration();

        /// <summary>
        /// The configuration
        /// </summary>
        private static readonly IConfigurationRoot _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        /// <summary>
        /// Binds the database configuration.
        /// </summary>
        /// <returns></returns>
        private static SampleDatabaseSettings BindDatabaseConfiguration()
        {
            SampleDatabaseSettings sampleDb = _configuration.Get<SampleDatabaseSettings>();
            _configuration.GetSection("SampleDbSettings").Bind(sampleDb);

            return sampleDb;
        }
    }
}