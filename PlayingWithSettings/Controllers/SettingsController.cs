using Microsoft.AspNetCore.Mvc;

namespace PlayingWithSettings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SettingsController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [HttpGet("{setting}")]
        public IActionResult Get(string setting)
        {
            var value = this._configuration[setting];

            if (value == null)
                return BadRequest();

            return Ok(value);
        }
    }
}
