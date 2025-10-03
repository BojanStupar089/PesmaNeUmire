using Microsoft.AspNetCore.Mvc;

namespace PesmaNeUmire.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZvezdaController : Controller
    {
        public IActionResult Get()
        {
            return Ok("Sampioni EVROPE I SVETA 91");
        }
    }
}
