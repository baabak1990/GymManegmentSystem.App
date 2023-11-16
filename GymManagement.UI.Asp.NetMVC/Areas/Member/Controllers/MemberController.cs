using GymManagement.UI.Asp.NetMVC.Contracts;
using GymManagement.UI.Asp.NetMVC.Models.MemberShipVM;
using GymManagement.UI.Asp.NetMVC.Models.MemberVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymManagement.UI.Asp.NetMVC.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberController : Controller
    {
        private readonly IMemberServices _services;
        private readonly IMembershipServices _membershipServices;
        public MemberController(IMemberServices services, IMembershipServices membershipServices)
        {
            _services = services;
            _membershipServices = membershipServices;
        }
        // GET: MemberController
        public async Task<ActionResult> Index()
        {
            var members = await _services.GetMembersAsync();
            return View(members);
        }

        // GET: MemberController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var member = await _services.GetMemberAsync(id);
            if (member == null)
            {
                throw new Exception("Ops   Something is Wrong !!!");
            }
            return View(member);
        }

        // GET: MemberController/Create

        [HttpGet]
        public ActionResult Create()
        {
            List<SelectListItem> memberships = new List<SelectListItem>()
            {
                new SelectListItem("Select your Membership type", ""),
                new SelectListItem("Gold", "1"),
                new SelectListItem("Silver", "2"),
                new SelectListItem("Bronze", "4"),
                new SelectListItem("Daily", "6")

            };
            List<SelectListItem> gender = new List<SelectListItem>()
            {
                new SelectListItem("Please select your gender", ""),
                new SelectListItem("Male", "1"),
                new SelectListItem("Female", "2"),
                new SelectListItem("Rather not to say", "3"),
            };
            ViewBag.Memberships = memberships;
            ViewBag.Gender = gender;
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateMemberVm memberVm)
        {
            #region SelectlistItems

            List<SelectListItem> memberships = new List<SelectListItem>()
            {
                new SelectListItem("Select your Membership type", ""),
                new SelectListItem("Gold", "1"),
                new SelectListItem("Silver", "2"),
                new SelectListItem("Bronze", "4"),
                new SelectListItem("Daily", "6")

            };
            List<SelectListItem> gender = new List<SelectListItem>()
            {
                new SelectListItem("Please select your gender", ""),
                new SelectListItem("Male", "1"),
                new SelectListItem("Female", "2"),
                new SelectListItem("Rather not to say", "3"),
            };
            ViewBag.Gender = gender;
            ViewBag.Memberships = memberships;

            #endregion
            try
            {
             
                var response = await _services.CreateMember(memberVm);
                if (response.Success)
                {
                    return RedirectToAction(nameof(Index));
                }

                ModelState.AddModelError("", response.ValidationError);
            }
            catch(Exception ex)
            {
                 ModelState.AddModelError("MobileNumber", "Check your Mobile number!!!");
            }
            return View(memberVm);
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
