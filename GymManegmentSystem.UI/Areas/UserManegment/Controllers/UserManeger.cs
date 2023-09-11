using Microsoft.AspNetCore.Mvc;

namespace GymManegmentSystem.UI.Areas.UserManegment.Controllers
{
    [Area(nameof(UserManegment))]
    public class UserManeger : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
