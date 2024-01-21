using Microsoft.AspNetCore.Mvc;
using NetCore.Web.Models;
using System.Diagnostics;

namespace NetCore.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]//Get방식으로 접근했을 때 보여주는 View page
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//유효속성 검증(위조 방지 토큰통해 view로부터 받은 Post 데이터 유효값인지 검증함 -> 유효하면 Login method에 접근하도록.)
        public IActionResult Login(LoginInfo login)
        {
            string message = string.Empty;

            if (ModelState.IsValid)
            {
                string userid = "jsdsdgrd";
                string password = "123456"; //ㄷ데이터베이스에서 가져왔따고 가정
                if (login.Userid.Equals(userid) && login.Password.Equals(password))
                {
                    TempData["Message"] = "로그인이 성공적으로 이루어졌습니다.";
                    return RedirectToAction("Index", "Home");//index뷰, Home controller로 이동 
                }
                else
                {
                    message = "로그인 되지 않았습니다";
                }

            }
            else
            {
                message = "로그인 정보를 올바르게 입력하세요";
            }
            ModelState.AddModelError(string.Empty, message);
            return View(login);
        }
    }
}
