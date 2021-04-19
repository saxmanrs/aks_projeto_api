using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aks_projeto_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ServerController> _logger;

        public ServerController(ILogger<ServerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {

            return "Nome da Maquina : " + Environment.MachineName + " | Sistema operacional : " + Environment.OSVersion.VersionString;

        }
    }
}
