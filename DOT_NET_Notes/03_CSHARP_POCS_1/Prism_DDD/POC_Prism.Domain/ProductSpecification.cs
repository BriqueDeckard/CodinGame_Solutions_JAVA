// -----------------------------------------------------------------------
//  <copyright file="ProductSpecification.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace POC_Prism.Domain
{
    using POC_Prism.Domain.Specification;

    //TODO : SPEC 1
    /// <summary>
    /// Specification for product search.
    /// </summary>
    public static class ProductSpecification
    {
        //TODO : SPEC 2s
        /// <summary>
        /// Searches the specified search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <param name="isAdmin">if set to <c>true</c> [is admin].</param>
        /// <returns></returns>
        public static ISpecification<Product> Search(string searchText, bool isAdmin)
        {
            Specification<Product> specification = new TrueSpecification<Product>();

            if (!isAdmin)
            {
                specification &= new DirectSpecification<Product>(w => w.Reference.Contains("P"));
            }

            if (!string.IsNullOrWhiteSpace(searchText) | searchText.Equals("*"))
            {
                var searchSpecification =
                    //First spec for OR --> where ( name like field % or description contains ...)
                    new OrSpecification<Product>(new DirectSpecification<Product>(w => w.Name.StartsWith(searchText)),
                    new DirectSpecification<Product>(w => w.Description.Contains(searchText)));

                specification &= searchSpecification;
            }

            return specification;
        }
    }
}