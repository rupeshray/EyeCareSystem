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
        public IActionResult LoginAsync()
        {
            return View(new LoginViewModel
            {

            });
        }

        [AcceptVerbs("GET")]
        public IActionResult LogoutAsync()
        {
            return RedirectToAction("LoginAsync", "Authentication");
        }

    }
}
