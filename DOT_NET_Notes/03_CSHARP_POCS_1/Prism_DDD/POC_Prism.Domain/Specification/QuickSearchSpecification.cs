// ------------------------------------------------------------------------
//  <copyright file="QuickSearchSpecification.cs" company="Modis">
//   Copyright © 2017 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace  POC_Prism.Domain.Specification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// A Smart Search Specification is a simple implementation of smart search on salesforce entity.
    /// </summary>
    /// <typeparam name="TEntity">Type of entity that check this specification.</typeparam>
    public sealed class QuickSearchSpecification<TEntity> : Specification<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Contains method info.
        /// </summary>
        private static readonly MethodInfo ContainsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });

        /// <summary>
        /// To lower method info.
        /// </summary>
        private static readonly MethodInfo ToUpperMethod = typeof(string).GetMethod("ToUpper", Type.EmptyTypes);

        /// <summary>
        /// All Combinations of strings
        /// </summary>
        private readonly IList<string> _criteriasCombinations;

        /// <summary>
        /// The list of properties to search on.
        /// </summary>
        private readonly IList<Expression<Func<TEntity, string>>> _searchingProperties;

        /// <summary>
        /// The search criteria.
        /// </summary>
        private string[] _searchCriteria;

        #region ----- Constructor -----

        /// <summary>
        /// Initializes a new instance of the <see cref="QuickSearchSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="searchingProperties">The properties to search on.</param>
        public QuickSearchSpecification(string searchCriteria, params Expression<Func<TEntity, string>>[] searchingProperties)
        {
            this._criteriasCombinations = this.GetAllCombinationsLevels(searchCriteria);

            this._searchingProperties = searchingProperties != null
                ? new List<Expression<Func<TEntity, string>>>(searchingProperties)
                : new List<Expression<Func<TEntity, string>>>();
        }

        #endregion

        #region ----- Override Method -----

        /// <summary>
        /// Satisfied By Pattern.
        /// </summary>
        /// <returns>The expression.</returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            // Default search return last viewed saleforce object items.
            if (this._searchingProperties.Count == 0 || !this._criteriasCombinations.Any())
            {
                return new TrueSpecification<TEntity>().SatisfiedBy();
            }

            IList<Expression<Func<TEntity, bool>>> expressions = new List<Expression<Func<TEntity, bool>>>();

            foreach (var property in this._searchingProperties)
            {
                foreach (var criteria in this._criteriasCombinations)
                {
                    var propertyBody = property.Body;
                    var propertyParameter = property.Parameters[0];

                    var toUppExpression = Expression.Call(propertyBody, ToUpperMethod);

                    var propertyExpression = Expression.Call(toUppExpression, ContainsMethod, Expression.Constant(criteria));

                    var expression = Expression.Lambda<Func<TEntity, bool>>(propertyExpression, propertyParameter);

                    expressions.Add(expression);
                }
            }

            return expressions.Aggregate((previous, next) => previous.Or(next));
        }

        #endregion

        /// <summary>
        /// Get All Combinations of search criteria
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        private IList<string> GetAllCombinationsLevels(string searchCriteria)
        {
            this._searchCriteria = searchCriteria.Split(' ');
            var combinations = new List<string>();

            // Get All Level of Combinations
            for (var level = this._searchCriteria.Length; level > 0; level--)
            {
                combinations.AddRange(this.GetCombinations(0, level));
            }

            return combinations;
        }

        /// <summary>
        /// Get Combinations for a level
        /// </summary>
        /// <param name="start"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private IEnumerable<string> GetCombinations(int start, int level)
        {
            // Get All Element of Combinations for a specific Level
            for (var i = start; i < this._searchCriteria.Length; i++)
            {
                if (level == 1)
                {
                    yield return this._searchCriteria[i].ToUpper();
                }
                else
                {
                    foreach (var combination in this.GetCombinations(i + 1, level - 1))
                    {
                        yield return $"{this._searchCriteria[i].ToUpper()} {combination}";
                    }
                }
            }
        }
    }
}