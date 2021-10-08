using System.Collections.Generic;
using System.Linq;
using Prototype.ApplicationServices.Contracts;
using Prototype.CrossCutting.IoC.IoCContainer;
using Prototype.Domain.Contracts.Dtos;
using Unity;

namespace Prototype.API.Console
{
    /// <summary>
    ///     Entry point of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     Injected application domainService
        /// </summary>
        private static IPrototypeApplicationService _appService;

        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Program : Beginning");
            System.Console.ReadKey();

            // Get the dependencies
            GetDependentInstances();
            System.Console.ReadKey();

            // Run the demo
            Demonstration();
            System.Console.WriteLine("Program : End");
        }

        #region IoC management

        /// <summary>
        ///     Gets the dependent instances.
        /// </summary>
        /// <returns></returns>
        private static void GetDependentInstances()
        {
            System.Console.WriteLine("Program : Get dependent instances");
            var container = IoCUnityContainer.Register();
            _appService = container.Resolve<IPrototypeApplicationService>();
            System.Console.WriteLine("\nProgram : Got instances.");
        }

        #endregion

        #region Demonstration

        /// <summary>
        ///     Demonstrations this instance.
        /// </summary>
        private static void Demonstration()
        {
            System.Console.WriteLine("\nProgram : Demonstration");

            #region DbCleaning

            CleansTheDatabase();

            #endregion

            #region Entities creation

            CreatesTheEntities();

            #endregion

            #region Entities manipulation

            GetsOneEntityByItsId();

            GetsAllTheEntities();

            SearchEntitiesByText();

            #endregion
        }

        /// <summary>
        ///     Searches the entities by text.
        /// </summary>
        private static void SearchEntitiesByText()
        {
            // SearchEntitiesByText in entities
            System.Console.WriteLine("\nProgram : SearchEntitiesByText for 'Azathoth' ... ");
            var azathoth = _appService.SearchEntitiesByText("Azathoth").FirstOrDefault();
            System.Console.ReadKey();
            System.Console.WriteLine("Found : {0}", azathoth?.StringValue);
            System.Console.ReadKey();
        }

        /// <summary>
        ///     Gets all the entities.
        /// </summary>
        private static void GetsAllTheEntities()
        {
            // Gets all the entities
            System.Console.WriteLine("Program : Get all sample entities");
            var entities = _appService.GetAllSampleEntities();
            foreach (var sampleEntity in entities)
                System.Console.WriteLine("Program : Found entities -> {0} ", sampleEntity);
            System.Console.ReadKey();
        }

        /// <summary>
        ///     Gets the one entity by its identifier.
        /// </summary>
        private static void GetsOneEntityByItsId()
        {
            // Gets an entity by its ID
            var id = 1;
            var entity = _appService.GetSampleEntity(id);
            System.Console.WriteLine(entity != null
                ? "\nProgram : Found entity for id : " + id + " -> " + entity
                : "Entity not found");
            System.Console.ReadKey();
        }

        /// <summary>
        ///     Creates the entities.
        /// </summary>
        /// <returns></returns>
        private static void CreatesTheEntities()
        {
            // Creates entities with strings
            var bladeRunners = new List<string> {"Rick Deckard", "Gaff", "Dave Holden"};
            bladeRunners.ForEach(b => _appService.CreateSampleEntity(b));

            // Creates entities with dto
            var replicants = new List<SampleEntityDto>
            {
                new("Rachel", 2000, null),
                new("Roy Batty", 2600, null),
                new("Leon Kowalski ", 800, null)
            };
            replicants.ForEach(r => _appService.CreateSampleEntity(r));

            System.Console.ReadKey();
        }

        /// <summary>
        ///     Cleans the database.
        /// </summary>
        /// <returns></returns>
        private static void CleansTheDatabase()
        {
            System.Console.WriteLine("Cleaning the database.");
            var entitiesToRemove = _appService.GetAllSampleEntities();
            foreach (var sampleEntity in entitiesToRemove) _appService.RemoveEntity(sampleEntity);
            System.Console.ReadKey();
        }

        #endregion
    }
}