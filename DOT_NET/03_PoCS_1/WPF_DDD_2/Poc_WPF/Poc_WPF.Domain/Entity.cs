// -----------------------------------------------------------------------
//  <copyright file="Entity.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Poc_WPF.Domain
{
    using POC_Prism.Domain;

    public class Entity : IEntity
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get => _body; set => _body = value; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [StringLength(20)]
        public string reference { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get => _title; set => _title = value; }

        /// <summary>
        /// The body
        /// </summary>
        private string _body;

        /// <summary>
        /// The title
        /// </summary>
        private string _title;
    }
}