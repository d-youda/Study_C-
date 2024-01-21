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

        [HttpGet]//Get������� �������� �� �����ִ� View page
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//��ȿ�Ӽ� ����(���� ���� ��ū���� view�κ��� ���� Post ������ ��ȿ������ ������ -> ��ȿ�ϸ� Login method�� �����ϵ���.)
        public IActionResult Login(LoginInfo login)
        {
            string message = string.Empty;

            if (ModelState.IsValid)
            {
                string userid = "jsdsdgrd";
                string password = "123456"; //�������ͺ��̽����� �����Ե��� ����
                if (login.Userid.Equals(userid) && login.Password.Equals(password))
                {
                    TempData["Message"] = "�α����� ���������� �̷�������ϴ�.";
                    return RedirectToAction("Index", "Home");//index��, Home controller�� �̵� 
                }
                else
                {
                    message = "�α��� ���� �ʾҽ��ϴ�";
                }

            }
            else
            {
                message = "�α��� ������ �ùٸ��� �Է��ϼ���";
            }
            ModelState.AddModelError(string.Empty, message);
            return View(login);
        }
    }
}
