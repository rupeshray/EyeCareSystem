using Microsoft.AspNetCore.Mvc;

namespace eyeCareUI.Controllers
{
    public class BaseController : Controller
    {
        // GET: BaseController
        public ActionResult Index()
        {
            return View();
        }

    }
}
