using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WpfApp1.Infrastructure.Data.Test
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using WpfApp1.Domain;
    using WpfApp1.Infrastructure.Data.Migrations;
    using WpfApp1.Infrastructure.Data.UnitofWork;

    [TestClass]
    public class DbContextTest
    {
        [TestMethod]
        public void AddProductTest01()
        {
            var product = new Product
            {
                Name = "Product 01",
                CreatedDate = DateTime.Now,
                Description = "Mon meilleur Produit",
                IsActivated = true,
                Reference = "P001",
            };

            using (var context = new WpfAppContext())
            {
                context.Products.AddOrUpdate(x => x.Name, product);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void AddProductTest02()
        {
            var product = new Product
            {
                Name = "Product 02",
                CreatedDate = DateTime.Now,
                Description = "Mon presque meilleur Produit",
                IsActivated = true,
                Reference = "P002",
                ProductPrices = new List<ProductPrice>
                                              {
                                                  new ProductPrice {CreatedDate = DateTime.Now.AddDays(-1), PriceExcludingVat = 10.0, VatId = 1},
                                                  new ProductPrice {CreatedDate = DateTime.Now, PriceExcludingVat = 10.5, VatId = 1},
                                              }
            };

            using (var context = new WpfAppContext())
            {
                context.Products.AddOrUpdate(x => x.Name, product);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void CreateDbTest01()
        {
            var currentConfiguration = new Configuration();

            var migrator = new DbMigrator(currentConfiguration);
            migrator.Update();

            using (var context = new WpfAppContext())
            {
            }
        }

        [TestMethod]
        public void UpdateProductTest01()
        {
            using (var context = new WpfAppContext())
            {
                var productId = context.Products
                                       .Where(w => w.Reference.Equals("P002"))
                                       .Select(s => s.Id).First();

                var productPrice = new ProductPrice()
                {
                    ProductId = productId,
                    CreatedDate = DateTime.Now,
                    PriceExcludingVat = 10.4,
                    VatId = 1
                };

                context.ProductPrices.Add(productPrice);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void UpdateProductTest02()
        {
            using (var context = new WpfAppContext())
            {
                var product = context.Products
                                       .Where(w => w.Reference.Equals("P001"))
                                       .Include(i => i.ProductPrices)
                                       .First();

                product.ProductPrices.Add(new ProductPrice()
                {
                    CreatedDate = DateTime.Now,
                    PriceExcludingVat = 10.4,
                    VatId = 1
                });

                context.Products.AddOrUpdate(x => x.Reference, product);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void UpdateProductTest03()
        {
            using (var context = new WpfAppContext())
            {
                var product = context.Products
                                     .Where(w => w.Reference.Equals("P001"))
                                     .Include(i => i.ProductPrices)
                                     .First();

                var price = product.ProductPrices.FirstOrDefault(w => w.PriceExcludingVat == 10.4);

                if (price != null)
                {
                    price.PriceExcludingVat = 10.43;
                    price.CreatedDate = DateTime.Now;
                }

                //context.Products.AddOrUpdate(x => x.Reference, product);
                context.SaveChanges();
            }
        }
    }
}