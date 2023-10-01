using Microsoft.AspNetCore.Mvc;

namespace GymManegmentSystem.UI.Areas.UserManegment.Controllers
{
    [Area("UserManegment")]
    [Route("UserManegment/[controller]/[action]")]
    public class UserManeger : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("AddMember")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddMember(IFormCollection collection)
        {
            return View();
        }

        [HttpGet]
        
        public IActionResult PR()
        {
            return View();
        }

    }
}
