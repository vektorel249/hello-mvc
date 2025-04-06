using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vektorel.GameCenter.Entities;
using Vektorel.GameCenter.Models;

namespace Vektorel.GameCenter.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = ModelState.Values
                                          .SelectMany(s => s.Errors)
                                          .Select(s => s.ErrorMessage)
                                          .ToList();
                return View();
            }
            var user = new User
            {
                FullName = model.FullName,
                UserName = model.EMail.ToLower(),
                NormalizedEmail = model.EMail.ToLower(),
                NormalizedUserName = model.EMail.ToLower(),
                Email = model.EMail,
            };
            var result = userManager.CreateAsync(user, model.Password)
                                    .GetAwaiter()
                                    .GetResult();
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Auth");
            }
            ViewBag.Error = result.Errors.Select(s => s.Description).ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Giriş bilgileri hatalı";
                return View();
            }
            var user = userManager.FindByEmailAsync(model.EMail).GetAwaiter().GetResult();
            if (user is null)
            {
                ViewBag.Error = "Kullanıcı bulunamadı";
                return View();
            }
            var result = signInManager.PasswordSignInAsync(user, model.Password, true, false).GetAwaiter().GetResult();
            if (!result.Succeeded)
            {
                ViewBag.Error = "Giriş başarısız";
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult Denied()
        {
            return View();
        }
    }

}
