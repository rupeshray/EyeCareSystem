using EyeCareUI.Services.SystemNavigationServices;
using Microsoft.AspNetCore.Mvc;
namespace EyeCareUI.ViewComponents.SystemNavigation
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly INavigationService _navigationService;
        public NavigationViewComponent(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menus = await _navigationService.GetMenuAsync();
            return View(menus);
        }
    }
}
