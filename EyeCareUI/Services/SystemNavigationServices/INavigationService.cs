using EyeCareUI.Models;
using EyeCareUI.Models.SystemNavigation;

namespace EyeCareUI.Services.SystemNavigationServices
{
    public interface INavigationService
    {
        Task<List<NavigationModel>> GetAllAsync();
        Task<List<MenuModel>> GetMenuAsync();
    }
}
