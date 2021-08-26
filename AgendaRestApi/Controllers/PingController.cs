using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AgendaRestApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return Ok(new
            {
                pong = true
            });
        }
    }
}