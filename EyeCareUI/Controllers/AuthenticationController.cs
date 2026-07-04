using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: AuthenticationController
        public ActionResult LoginAsync()
        {
            return View();
        }

    }
}
