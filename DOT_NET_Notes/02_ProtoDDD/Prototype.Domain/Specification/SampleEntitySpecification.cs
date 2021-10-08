using Prototype.Domain.AggregatesModel.SampleEntityAggregate;
using Prototype.Domain.Contracts.SeedWork;

namespace Prototype.Domain.Specification
{
    public class SampleEntitySpecification
    {
        public static ISpecification<SampleEntity> Search(string text)
        {
            Specification<SampleEntity> specification = new TrueSpecification<SampleEntity>();

            if (!string.IsNullOrWhiteSpace(text) | text.Equals("*"))
            {
                var searchSpecification =
                    //First spec for OR --> where ( name like field % or description contains ...)
                    new OrSpecification<SampleEntity>(
                        new DirectSpecification<SampleEntity>(w => w.StringValue.StartsWith(text)),
                        new DirectSpecification<SampleEntity>(w => w.StringValue.Contains(text)));

                specification &= searchSpecification;
            }

            return specification;
        }
    }
}