using EyeCareUI.DataBase;
using EyeCareUI.GlobalModels;
using EyeCareUI.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using X.PagedList.EF;
using X.PagedList.Extensions;

namespace EyeCareUI.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task<IPagedList<CustomerModel>> GetAllCustomers(PaginationModel pagination)
        {
            return await _context.Customers.AsNoTracking().OrderByDescending(x => x.Id).Select(x => new CustomerModel
            {
                Id = x.Id,
                CustomerName = x.CustomerName,
                CustomerId = x.CustomerId,
                CustomerAddress = x.CustomerAddress,
                CustomerAge = x.CustomerAge,
                ClientIp = x.ClientIp,
                IdCompany = x.IdCompany,
                IdBranch = x.IdBranch,
                IdDepartment = x.IdDepartment,
                CreatedBy = x.CreatedBy,
                UpdatedBy = x.UpdatedBy,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate,
                FollowupCount = x.FollowupCount,
                Email = x.Email,
                Mobile = x.Mobile,
                Gender = x.Gender,
                IsActive = x.IsActive
            }).ToPagedListAsync(pagination.Page, pagination.PageSize);
        }
    }
}
