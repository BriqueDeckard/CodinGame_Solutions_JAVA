namespace POC_Prism.Infrastructure.Data.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    using POC_Prism.Domain;
    using POC_Prism.Infrastructure.data.Repositories;
    using POC_Prism.Infrastructure.data.UnitOfWork;

    using System.Collections.Generic;

    /// <summary>
    /// Description résumée pour RepositoryTest
    /// </summary>
    [TestClass]
    public class RepositoryTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryTest"/> class.
        /// </summary>
        public RepositoryTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        /// <summary>
        /// Obtient ou définit le contexte de test qui fournit
        /// des informations sur la série de tests active, ainsi que ses fonctionnalités.
        /// </summary>
        /// <value>
        /// The test context.
        /// </value>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        /// Gets the product test01.
        /// </summary>
        [TestMethod]
        public void GetProductTest01()
        {
            GenericRepository repository = new GenericRepository(new POC_PrismContext());

            IEnumerable<Product> results = repository.GetByFilter<Product, string>(w => w.Reference.Contains("P"), o => o.Reference, true);
        }

        /// <summary>
        /// Gets the product test02.
        /// </summary>
        [TestMethod]
        public void GetProductTest02()
        {
            GenericRepository repository = new GenericRepository(new POC_PrismContext());

            IEnumerable<string> results = repository.GetByFilter<Product, string, string>(s => s.Name, w => w.Reference.Contains("P"), o => o.Reference, true);
        }

        /// <summary>
        /// Gets the product test03.
        /// </summary>
        [TestMethod]
        public void GetProductTest03()
        {
            GenericRepository repository = new GenericRepository(new POC_PrismContext());

            IEnumerable<ProductSelectResult> selectResults = repository.GetByFilter<Product, string, ProductSelectResult>(s => new ProductSelectResult()
            {
                Name = s.Name,
                Id = s.Id,
                Price = s.ProductPrices.First().PriceExcludingVaT
            },
                w => w.Reference.Contains("P"),
                o => o.Reference, true);

            Assert.AreNotEqual(0, selectResults.Count());
        }

        /// <summary>
        /// Gets the search product test.
        /// </summary>
        [TestMethod]
        public void GetSearchProductTest()
        {
            var repository = new GenericRepository(new POC_PrismContext());
            var specification = ProductSpecification.Search("presque", false);
            var result = repository.GetByFilter<Product, string, ProductSelectResult>(
                s => new ProductSelectResult()
                {
                    Name = s.Name,
                    Id = s.Id,
                    Price = s.ProductPrices.OrderBy(o => o.CreatedDate).FirstOrDefault().PriceExcludingVaT
                },
                specification,
                o => o.Reference,
                true
            );
        }

        /// <summary>
        /// The test context instance
        /// </summary>
        private TestContext testContextInstance;

        #region Attributs de tests supplémentaires

        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //

        #endregion
    }
}