using Microsoft.AspNetCore.Mvc;

namespace LoginStartic.Controllers
{
    public class AccountController : Controller
    {
        private const string StaticUsername = "Leonardo";
        private const string StaticPassword = "1234";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == StaticUsername && password == StaticPassword)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Usuário ou Senha inválidos!";
            return View();
        }

    }
}
