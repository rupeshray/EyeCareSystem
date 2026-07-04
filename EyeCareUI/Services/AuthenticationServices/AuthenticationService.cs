using EyeCareUI.UnitOfWork;

namespace EyeCareUI.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
    }
}
