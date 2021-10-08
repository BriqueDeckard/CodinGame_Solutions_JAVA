using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        /**
        *   Summaries values
        */
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Names = new[]{
            "Nabuchodonosor", "Perseus", "Ptolemeus"
        };

        /**
        *   Logger
        */
        private readonly ILogger<CharactersController> _logger;

        /**
        *   Instatiate a new "CharactersController" object.
        */
        public CharactersController(ILogger<CharactersController> logger)
        {
            _logger = logger;
        }

        /**
        *   Get the weather forecast
        */
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 3).Select(index => new Character
            {
                Name = Names[rng.Next(Names.Length)],
                Age = rng.Next(100, 500)
            })
            .ToArray();
        }
    }
}
