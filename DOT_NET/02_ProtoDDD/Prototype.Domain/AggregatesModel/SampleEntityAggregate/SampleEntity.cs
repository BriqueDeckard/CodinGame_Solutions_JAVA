using System.ComponentModel.DataAnnotations.Schema;
using Prototype.Domain.Contracts.AggregatesModelContracts.SampleEntityAggregateContracts;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.AggregatesModel.SampleEntityAggregate
{
    /// <summary>
    ///     Sample Entity implementation.
    ///     An "Entity" object contains an "identity" :
    ///     - That identity remains the same during all the states of the software
    ///     - There should not be 2 entities with the same identity otherwise
    ///     you will have software in an inconsistent state.
    ///     - The identity can be a unique identifier or a combination of several
    ///     members of the entity.
    /// </summary>
    [Table("SampleEntity")]
    public class SampleEntity : Entity, ISampleEntity
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SampleEntity" /> class.
        /// </summary>
        public SampleEntity()
        {
        }

        /// <summary>
        ///     Instantiates a new "SampleEntity" object.
        /// </summary>
        /// <param name="stringAttribute"></param>
        public SampleEntity(string stringAttribute, double price)
        {
            StringValue = stringAttribute;
        }

        /// <inheritdoc />
        public string StringValue { get; private set; }

        /// <summary>
        ///     Gets or sets the price value.
        /// </summary>
        /// <value>
        ///     The price value.
        /// </value>
        public double PriceValue { get; set; }


        /// <inheritdoc />
        public void SomeStringManipulation(string text)
        {
            StringValue += text;
        }


        /// <summary>
        ///     Converts to string.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return GetType().Name + "\n\t-> Id : " + Id + "\n\t-> String value : '" + StringValue;
        }
    }
}