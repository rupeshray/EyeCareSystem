using EyeCareUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: AuthenticationController
        private readonly ILogger<AuthenticationController> _logger;
        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [AcceptVerbs("GET")]

        public IActionResult Login()
        {
            return View(new LoginViewModel
            {
                loginModel = new LoginModel { UserName = string.Empty, Password = string.Empty },
            });
        }

        [AcceptVerbs("POST")]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            // If authentication fails, return the login view with an error message
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

        [AcceptVerbs("GET")]
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Authentication");
        }

    }
}
