using EyeCareUI.GlobalModels;
using EyeCareUI.Models;
using X.PagedList;

namespace EyeCareUI.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<IPagedList<CustomerModel>> GetAllCustomers(PaginationModel pagination);
    }
}
