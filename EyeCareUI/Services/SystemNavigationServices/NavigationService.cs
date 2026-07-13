using EyeCareUI.DataBase;
using EyeCareUI.Models;
using Microsoft.Data.SqlClient;
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

        public async Task<List<EyeCareUI.Models.SystemNavigation.MenuModel>> GetMenuAsync(int IdUser, string Area, string Controller, string Action)
        {
            return await _context.MenuModels
                 .FromSqlRaw(
                  "EXEC dbo.usp_SideNavigation @paramIdLogin, @paramArea, @paramController, @paramAction",
                  new SqlParameter("@paramIdLogin", IdUser),
                  new SqlParameter("@paramArea", Area ?? string.Empty),
                  new SqlParameter("@paramController", Controller),
                  new SqlParameter("@paramAction", Action))
                  .AsNoTracking().AsAsyncEnumerable().Select(x => new Models.SystemNavigation.MenuModel
                  {
                      IdSideNavigation = x.IdSideNavigation,
                      IdParent = x.IdParent,
                      Menu = x.Menu,
                      IsMenu = x.IsMenu,
                      ParentOrder = x.ParentOrder,
                      ChildOrder = x.ChildOrder,
                      CSSClass = x.CSSClass,
                      CSSIcon = x.CSSIcon,
                      CSSSubClass = x.CSSSubClass,
                      CSSSubIcon = x.CSSSubIcon,
                      DefaultURL = x.DefaultURL,
                      ParentStatusClass = x.ParentStatusClass,
                      StatusClass = x.StatusClass
                  }).ToListAsync();
        }
    }
}
