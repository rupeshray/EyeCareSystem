using EyeCareUI.GlobalModels;
using EyeCareUI.Models;
using X.PagedList;

namespace EyeCareUI.ViewModels
{
    public class CustomerViewModel : BreadCrumbModel
    {
        public CustomerViewModel(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }
        public CustomerModel DataModel { get; set; }
        public IPagedList<CustomerModel> PagedDBList { get; set; }
    }
}
