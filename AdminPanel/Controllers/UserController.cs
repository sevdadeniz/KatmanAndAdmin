using AdminPanel.Models;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager _userManager;
        public UserController()
        {
            _userManager = new UserManager();
        }

        public IActionResult LoginPanel()
        {
            return View();
        }

        public ActionResult Login(UserModel model)
        {
            bool result = _userManager.Login(model.Email, model.Password);
            if (result)
            {
                TempData["ErrorMessage"] = "";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "Kullanıcı adı veya şifre hatalı...";
                return RedirectToAction("LoginPanel", "User");
            }

        }
    }
}
