using Microsoft.AspNetCore.Mvc;

namespace GymManegmentSystem.UI.Areas.UserManegment.Controllers
{
    [Area("UserManegment")]
    [Route("UserManegment/[controller]/[action]")]
    public class UserManeger : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddMember(IFormCollection collection)
        {
            return View();
        }

        [HttpGet("PR")]
        
        public IActionResult PR()
        {
            return View();
        }

    }
}
