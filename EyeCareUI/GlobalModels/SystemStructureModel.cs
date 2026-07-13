namespace EyeCareUI.GlobalModels
{
    public class SystemStructureModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SystemStructureModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? AreaName
        {
            get
            {
                return _httpContextAccessor.HttpContext?
                    .GetRouteValue("area")?
                    .ToString();
            }
        }
        public string? ActionName
        {
            get
            {
                return _httpContextAccessor.HttpContext?
                    .GetRouteValue("action")?
                    .ToString();
            }
        }

        public string? ControllerName
        {
            get
            {
                return _httpContextAccessor.HttpContext?
                    .GetRouteValue("controller")?
                    .ToString();
            }
        }

        public string? BaseURL
        {
            get
            {
                return _httpContextAccessor.HttpContext?
                    .Request.Path
                    .ToString();
            }
        }
    }
}
