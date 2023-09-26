using Microsoft.AspNetCore.Mvc;

namespace GymManegmentSystem.UI.Areas.UserManegment.Controllers
{
    [Area(nameof(UserManegment))]
    public class UserManeger : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            return View();
        }

    }
}
