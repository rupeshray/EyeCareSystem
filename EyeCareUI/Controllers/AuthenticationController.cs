using EyeCareUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: AuthenticationController

        [AllowAnonymous]
        [AcceptVerbs("GET")]
        public ActionResult LoginAsync()
        {
            return View(new LoginViewModel
            {

            });
        }

        [AcceptVerbs("GET")]
        public ActionResult LogoutAsync()
        {
            return RedirectToAction("LoginAsync", "Authentication");
        }

    }
}
