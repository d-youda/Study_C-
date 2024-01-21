using Microsoft.AspNetCore.Mvc;

namespace Membership.Web.Controllers
{
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]//Get방식으로 서버에 접근할 때 보여줄 VIew page
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//유효 속성 검증

    }
}
