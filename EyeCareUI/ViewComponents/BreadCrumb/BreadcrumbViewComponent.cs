using EyeCareUI.GlobalModels;
using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.ViewComponents.BreadCrumb
{
    public class BreadcrumbViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(BreadCrumbModel model)
        {
            return View(model);
        }
    }
}
