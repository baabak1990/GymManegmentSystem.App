using GymManagement.UI.Asp.NetMVC.Contracts;
using GymManagement.UI.Asp.NetMVC.Models.MemberVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.UI.Asp.NetMVC.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberController : Controller
    {
        private readonly IMemberServices _services;
        public MemberController(IMemberServices services)
        {
            _services = services;
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
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateMemberVm memberVm)
        {
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
                throw new Exception("Something wrong , please try again !");
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
