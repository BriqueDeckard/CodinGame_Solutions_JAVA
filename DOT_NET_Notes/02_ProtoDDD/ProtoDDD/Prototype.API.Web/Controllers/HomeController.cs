using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Prototype.ApplicationServices.Contracts;
using Prototype.CrossCutting.IoC.IoCContainer;
using Unity;

namespace Prototype.API.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IPrototypeApplicationService _applicationService;

        public HomeController()
        {
            Console.WriteLine("Program : Get dependent instances");
            var container = IoCUnityContainer.Register();
            _applicationService = container.Resolve<IPrototypeApplicationService>();
            Console.WriteLine("\nProgram : Got instances.");
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            var data = _applicationService.GetAllSampleEntities().Select(s => s.StringValue+"\n");


            return data;
        }
    }
}