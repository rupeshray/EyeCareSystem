using eyeCareUI.Controllers;
using EyeCareUI.GlobalModels;
using EyeCareUI.Services.CustomerServices;
using EyeCareUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EyeCareUI.Controllers
{
    public class Customer : BaseController
    {
        private readonly ICustomerService _customerService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public Customer(ICustomerService customerService, IHttpContextAccessor accessor)
        {
            this._customerService = customerService;
            this._httpContextAccessor = accessor;
        }

        [AcceptVerbs("GET")]
        public async Task<IActionResult> Index(PaginationModel pagination)
        {
            return View(new CustomerViewModel(_httpContextAccessor)
            {
                ModalTitle = "Patients",
                Pagination = pagination,
                EnablePageSizeButton = true,
                EnableSearchButton = true,
                BreadCrumbTitle = "Patients",
                PagedDBList = await _customerService.GetAllCustomers(pagination)
            });
        }
    }
}
