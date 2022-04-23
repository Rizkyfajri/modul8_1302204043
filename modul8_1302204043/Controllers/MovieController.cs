using Microsoft.AspNetCore.Mvc;

namespace modul8_1302204043.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MovieController : Controller
    {

        [HttpGet(Name ="Movies")]
        [HttpPost(Name ="Movies")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
