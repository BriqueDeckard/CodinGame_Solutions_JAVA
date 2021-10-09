// -----------------------------------------------------------------------
//  <copyright file="SampleEntity.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using DDDMicroservice.Domain.ObjectValue;

namespace DDDMicroservice.Domain.Aggregates
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    /// <summary>
    /// Sample entity class.
    /// </summary>
    public class SampleEntity : ISampleEntity
    {
        /// <summary>
        /// Gets or sets a value indicating whether [boolean property].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [boolean property]; otherwise, <c>false</c>.
        /// </value>
        [BsonElement]
        [BsonRepresentation(BsonType.Boolean)]
        public bool BooleanProperty { get => _booleanProperty; set => _booleanProperty = value; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get => _id; set => _id = value; }

        /// <summary>
        /// Gets or sets the number property.
        /// </summary>
        /// <value>
        /// The number property.
        /// </value>
        [BsonElement("NumberProperty")]
        [BsonRepresentation(BsonType.Int64, AllowTruncation = true)]
        public int NumberProperty { get => _numberProperty; set => _numberProperty = value; }

        /// <summary>
        /// Gets or sets the object value.
        /// </summary>
        /// <value>
        /// The object value.
        /// </value>
        public SampleObjectValue ObjectValue { get; set; }

        /// <summary>
        /// Gets or sets the string property.
        /// </summary>
        /// <value>
        /// The string property.
        /// </value>
        [BsonElement("StringProperty")]
        public string StringProperty { get => _stringProperty; set => _stringProperty = value; }

        /// <summary>
        /// The boolean property
        /// </summary>
        private bool _booleanProperty;

        /// <summary>
        /// The identifier
        /// </summary>
        private string _id;

        /// <summary>
        /// The number property
        /// </summary>
        private int _numberProperty;

        /// <summary>
        /// The string property
        /// </summary>
        private string _stringProperty;
    }
}