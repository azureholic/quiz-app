using Microsoft.AspNetCore.Mvc;

namespace Quiz.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public string IsAlive()
        {
            return "Alive";
        }
        
    }
}
