using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace alternative_tracker_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WOWAccessController : ControllerBase
    {
        private readonly ILogger<WOWAccessController> _logger;

        public WOWAccessController(ILogger<WOWAccessController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get() => "it lives!";
    }
}
