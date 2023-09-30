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

        public ActionResult AddMember(IFormCollection collection)
        {
            return View();
        }


        [Route("rp")]
        public IActionResult PR()
        {
            return View();
        }

    }
}
