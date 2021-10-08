using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace  POC_Prism.Domain.Specification
{
    /// <summary>
    /// A specification that checks if all values in criterias are contained by a given Enumerable
    /// from an Entity. Note : This specification is WIP. To get the same behaviour, a Direct
    /// specification with u =&gt; parameterDto.Field.All(i =&gt; u.Field.Contains(i)) clause can be used.
    /// </summary>
    /// <typeparam name="TEntity">
    /// Type of the entity that contains the Enumerable
    /// </typeparam>
    /// <typeparam name="TField">
    /// a Type of Enumerable values.
    /// </typeparam>
    public class ComposeSpecification<TEntity, TField> : Specification<TEntity> where TEntity : class
    {
        /// <summary>
        /// All Method info.
        /// </summary>
        private static readonly MethodInfo
            AllMethod = typeof(ComposeExtension).GetMethod("CallAll").MakeGenericMethod(typeof(TField));

        /// <summary>
        /// Contains Method info.
        /// </summary>
        private static readonly MethodInfo ContainsMethod =
            typeof(ComposeExtension).GetMethod("CallContains").MakeGenericMethod(typeof(TField));

        /// <summary>
        /// Enumerable of properties to search.
        /// </summary>
        private readonly IEnumerable<TField> _criterias;

        /// <summary>
        /// Expression to select the field to search on
        /// </summary>
        private readonly Expression<Func<TEntity, IEnumerable<TField>>> _field;

        /// <summary>
        /// Constructor to init the Specification
        /// </summary>
        /// <param name="field">
        /// Expression to get the field to search on
        /// </param>
        /// <param name="criterias">
        /// Enumerable of properties to search
        /// </param>
        public ComposeSpecification(Expression<Func<TEntity, IEnumerable<TField>>> field, IEnumerable<TField> criterias)
        {
            this._field = field;
            this._criterias = criterias;
        }

        /// <summary>
        /// Satisfied By pattern
        /// </summary>
        /// <returns>
        /// An expression that checks if all values in criterias are contained in the given
        /// Enumerable field.
        /// </returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            // Get Enumerable selection expression and decompose it
            var fieldBody = this._field.Body;
            var fieldParameter = this._field.Parameters[0];

            // Build inner expression to check if a value is in the selected Enumerable

            // Build TField type parameter
            var containsParameter = Expression.Parameter(typeof(TField));

            // Build Expression body that calls contains on the selected Enumerable
            var containsBody = Expression.Call(null, ContainsMethod, fieldBody, containsParameter);

            // Build the complete expression with Contains method call.
            var containsExpression = Expression.Lambda<Func<TField, bool>>(containsBody, containsParameter);

            // Build the constant expression of the enumerable containing the search params
            var criteriasExpression = Expression.Constant(this._criterias);

            // Build the final expression
            var allBody = Expression.Call(null, AllMethod, criteriasExpression, containsExpression);

            return Expression.Lambda<Func<TEntity, bool>>(allBody, fieldParameter);
        }
    }

    internal static class ComposeExtension
    {
        public static bool CallAll<TField>(this IEnumerable<TField> source, Func<TField, bool> predicate)
        {
            return source.All(predicate);
        }

        public static bool CallContains<TField>(this IEnumerable<TField> source, TField value)
        {
            return source.Contains(value);
        }
    }
}