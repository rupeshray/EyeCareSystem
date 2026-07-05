using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
