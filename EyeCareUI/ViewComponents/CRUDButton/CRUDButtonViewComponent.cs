using EyeCareUI.GlobalModels;
using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.ViewComponents.CRUDButton
{
    public class CRUDButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(BreadCrumbModel model)
        {
            return View(model);
        }
    }
}
