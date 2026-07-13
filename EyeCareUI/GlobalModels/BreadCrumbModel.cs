namespace EyeCareUI.GlobalModels
{
    public class BreadCrumbModel : ModalFooterModel
    {
        public BreadCrumbModel(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }
        public bool EnableBreadCrumb { get; set; } = true;
        public bool EnableCreateButton { get; set; } = true;
        public bool EnableUpdateButton { get; set; } = false;
        public bool EnableDeleteButton { get; set; } = false;
        public bool EnableSearchButton { get; set; } = false;
        public bool EnableExportButton { get; set; } = false;
        public bool EnablePageSizeButton { get; set; } = false;
        public string CRUDTitle { get; set; } = "Menu/_CRUDCommon";
        public string FormName => ControllerName ?? string.Empty;
        public required string ModalTitle { get; set; }
        public string BreadCrumbTitle { get; set; } = string.Empty;
        public string BreadCrumbSubTitle => AreaName ?? string.Empty;
        public CRUDState CRUDState { get; set; }
        public int SearchByPageSize { get; set; }
        public required PaginationModel Pagination { get; set; }
        // public ActionPermissionModel ActionPermission { get { return HttpContext.Current.Session["ActionPermission"] as ActionPermissionModel; } }
        public string ListURL { get { return $"_List{this.ControllerName}"; } }
        public string CreateURL { get { return $"_Create{this.ControllerName}"; } }
        public string ReadURL { get { return $"_Read{this.ControllerName}"; } }
        public string UpdateURL { get { return $"_Update{this.ControllerName}"; } }
        public string DeleteURL { get { return $"_Delete{this.ControllerName}"; } }
        public string ExportURL { get { return $"_Export{this.ControllerName}"; } }
        public string ImportURL { get { return $"_Import{this.ControllerName}"; } }
        public string PrintURL { get { return $"_Print{this.ControllerName}"; } }
        public string ConfirmURL { get { return $"_Confirm{this.ControllerName}"; } }
        public string DownloadURL { get { return $"_Download{this.ControllerName}"; } }
        public string ParentViewTitle => $"_List{ControllerName}";
        public string ChildViewTitle => $"_List{ControllerName}";
        public string ReplacetargetID => $"replacetarget_{ControllerName}";
    }
}
