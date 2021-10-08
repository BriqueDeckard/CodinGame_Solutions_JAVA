// -----------------------------------------------------------------------
//  <copyright file="DbContextTest.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POC_Prism.Domain;
using POC_Prism.Infrastructure.data.UnitOfWork;

namespace POC_Prism.Infrastructure.Data.Test
{
    [TestClass]
    public class DbContextTest
    {
        [TestMethod]
        public void AddProductTest01()
        {
            Product product = new Product
            {
                Name = "Toto",
                CreatedDate = DateTime.Now,
                Description = "Best product",
                IsActivated = true,
                Reference = "P001"
            };

            using (var context = new POC_PrismContext())
            {
                // Ajout
                context.Products.AddOrUpdate(product);
                // Commit
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void AddProductTest02()
        {
            Product product = new Product
            {
                Name = "Tata",
                CreatedDate = DateTime.Now,
                Description = "Closest best product",
                IsActivated = true,
                Reference = "P001",
                ProductPrices = new List<ProductPrice>()
                {
                    new ProductPrice()
                    {
                        CreatedDate = DateTime.Now.AddDays(-1),
                        PriceExcludingVaT = 10.0,
                        VaTId = 1
                    }
                }
            };

            using (var context = new POC_PrismContext())
            {
                // Ajout
                context.Products.AddOrUpdate(product);
                // Commit
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void CreateDbTest01()
        {
            using (POC_PrismContext context = new POC_PrismContext())
            {
                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void CreateDbTest02()
        {
            Database.SetInitializer<POC_PrismContext>(new CreateDatabaseIfNotExists<POC_PrismContext>());
            //Database.SetInitializer<POC_PrismContext>(new MigrateDatabaseToLatestVersion<POC_PrismContext, POC_Prism.Infrastructure.Data.Migrations.Configuration>());
        }

        [TestMethod]
        public void UpdateProductTest01()
        {
            using (var context = new POC_PrismContext())
            {
                var productId = context.Products
                    .Where(w => w.Reference.Equals("P002"))
                    .Select(s => s.Id).First();

                var productPrice = new ProductPrice()
                {
                    ProductId = productId,
                    CreatedDate = DateTime.Now,
                    PriceExcludingVaT = 10.4,
                    VaTId = 1
                };

                context.ProductPrices.Add(productPrice);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void UpdateProductTest02()
        {
            using (var context = new POC_PrismContext())
            {
                var product = context.Products
                    .Where(w => w.Reference.Equals("P002"))
                    .Include(i => i.ProductPrices)
                    .First();

                product.ProductPrices.Add(new ProductPrice()
                {
                    CreatedDate = DateTime.Now,
                    PriceExcludingVaT = 10.4,
                    VaTId = 1
                });

                //  context.ProductPrices.AddOrUpdate(x => x.Reference, product);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void UpdateProductTest03()
        {
            using (var context = new POC_PrismContext())
            {
                var product = context.Products
                    .Where(w => w.Reference.Equals("P002"))
                    .Include(i => i.ProductPrices)
                    .First();

                var price = product.ProductPrices.FirstOrDefault(w => w.PriceExcludingVaT == 10.42);

                if (price != null)
                {
                    price.PriceExcludingVaT = 10.43;
                    price.CreatedDate = DateTime.Now;
                }

                // context.ProductPrices.AddOrUpdate(x => x.Reference, product);
                context.SaveChanges();

                // Change tracker !! TODO
                IEnumerable<DbEntityEntry> entries = context.ChangeTracker.Entries();
            }
        }
    }
}