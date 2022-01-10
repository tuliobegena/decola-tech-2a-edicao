using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Localiza.Frotas.Infra.;

namespace Localiza.Frotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            var singleton = new Singleton();
            return Ok(singleton);
        }
    }
}
