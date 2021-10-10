using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _01_SampleWebApi.models;

namespace _01_SampleWebApi.Controllers
{
    /// <summary>
    /// A controller in ASP.NET is a class inheriting from
    ///  ControllerBase. The base class provides properties
    /// and methods that are useful for handling HTTP requests
    ///
    /// The ApiController attribute enables a few handy behaviors,
    ///  like the automatic HTTP 400 responses when the model is
    ///  in error, the automatic binding of URL parameters to
    ///  method parameters, and similar.
    ///
    /// The Route attribute allows you to map a URL pattern to the
    ///  controller. In this specific case, you are mapping the
    ///  api/[controller] URL pattern to the controller.
    /// At runtime, the [controller] placeholder is replaced by
    /// the controller class name without the Controller suffix.
    /// That means that the SuperheroController will be mapped
    /// to the api/superhero URL, and this will be the base URL
    ///  for all the actions implemented by the controller.
    ///
    /// The Route attribute can be also applied to the methods of the controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHeroItem>
            SuperHeroes =
                new List<SuperHeroItem> {
                    new SuperHeroItem { Id = 1, Name = "Superman" },
                    new SuperHeroItem { Id = 2, Name = "Batman" },
                    new SuperHeroItem { Id = 3, Name = "Spiderman" }
                };

        /// <summary>
        ///  An action is a public method of a controller mapped to an HTTP verb.
        /// The method Get() allows the client to get the whole list of Superhero items.
        /// It is decorated with the HttpGet attribute which maps the method to HTTP
        /// GET requests sent to the api/superhero URL.
        /// The return type of the method is ActionResult<List<SuperheroItem>>.
        /// This means that the method will return a List<SuperheroItem> type
        ///  object or an object deriving from ActionResult type.
        ///  ActionResult type represents the HTTP status codes to be
        /// returned as a response.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<SuperHeroItem>> Get()
        {
            return Ok(SuperHeroes);
        }

        [HttpGet]
        [Route("{Id}")]
        public ActionResult<SuperHeroItem> GetActionResult(int id)
        {
            var superHeroItem = SuperHeroes.Find(x => x.Id == id);
            return superHeroItem == null ? NotFound() : Ok(superHeroItem);
        }

        /// <summary>
        /// the action is mapped to the HTTP POST verb via the HttpPost attribute.
        /// The Post() method has also a superheroItem parameter whose value comes
        /// from the body of the HTTP POST request.
        /// Here, the method checks if the term to be created already exists.
        /// If it is so, a 409 Conflict HTTP status code will be returned.
        /// Otherwise, the new item is appended to the Superheroes list.
        /// By following the REST guidelines, the action returns
        /// a 201 Created HTTP status code. The response includes the
        /// newly created item in the body and its URL in the Location HTTP header.
        /// </summary>
        /// <param name="superHeroItem"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post(SuperHeroItem superHeroItem)
        {
            var existingSuperHeroItem =
                SuperHeroes.Find(x => x.Id == superHeroItem.Id);
            if (existingSuperHeroItem != null)
            {
                return Conflict("Cannot create the Id because it already exists.");
            }
            else
            {
                SuperHeroes.Add (superHeroItem);
                var resourceUrl =
                    Request.Path.ToString() + '/' + superHeroItem.Id;
                return Created(resourceUrl, superHeroItem);
            }
        }

        /// <summary>
        /// The Put() method is decorated with the HttpPut attribute
        ///  that maps it to the HTTP PUT verb. In short, it checks
        /// if the Superhero item to be updated exists in the
        /// Superheroes list. If the item doesn't exist, it returns
        /// a 400 Bad Request HTTP status code. Otherwise, it
        /// updates the item's definition and returns a
        /// 200 OK HTTP status code.
        /// </summary>
        /// <param name="superHeroItem"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Put(SuperHeroItem superHeroItem)
        {
            // Retrieving the item
            var existingSuperHeroItem =
                SuperHeroes.Find(x => x.Id == superHeroItem.Id);

            if (existingSuperHeroItem == null)
            {
                return BadRequest("Cannot update a non existing item");
            }
            else
            {
                existingSuperHeroItem.Name = superHeroItem.Name;
                return Ok();
            }
        }

        /// <summary>
        /// The HttpDelete attribute maps the method Delete()
        /// to the DELETE HTTP verb.
        /// The Route attribute appends a new element to the URL.
        /// when a DELETE HTTP request hits the api/superhero/{Id}
        ///  URL pattern, the method checks if the item exists in
        /// the Superheroes list. If it doesn't exist, a 404 Not Found
        /// HTTP status code is returned.
        /// Otherwise, the Delete() method removes the item from
        /// the Superheroes list and returns a
        /// 204 No Content HTTP status code.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult Delete(int Id)
        {
            var superHeroItem = SuperHeroes.Find(x => x.Id == Id);

            if (superHeroItem == null)
            {
                return NotFound();
            }
            else
            {
                SuperHeroes.Remove (superHeroItem);
                return NoContent();
            }
        }
    }
}
