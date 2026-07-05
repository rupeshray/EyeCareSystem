using EyeCareUI.DataBase;
using EyeCareUI.Models;
using EyeCareUI.Models.SystemNavigation;
using Microsoft.EntityFrameworkCore;

namespace EyeCareUI.Services.SystemNavigationServices
{
    public class NavigationService : INavigationService
    {
        private readonly ApplicationDbContext _context;
        public NavigationService(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task<List<NavigationModel>> GetAllAsync()
        {
            return await this._context.SystemNavigations.AsNoTracking().Select(x => new NavigationModel
            {
                Id = x.Id,
                IdParent = x.IdParent,
                ParentOrder = x.ParentOrder,
                Navigation = x.Navigation,
                Area = x.Area,
                Controller = x.Controller,
                ActionName = x.ActionName,
                ChildOrder = x.ChildOrder,
                IsMenu = x.IsMenu,
                IsActive = x.IsActive,
                Cssclass = x.Cssclass,
                ClientIp = x.ClientIp
            }).ToListAsync();
        }

        public async Task<List<MenuModel>> GetMenuAsync()
        {
            return new List<MenuModel>();
        }
    }
}
