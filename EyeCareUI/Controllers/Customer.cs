using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
