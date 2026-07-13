namespace EyeCareUI.GlobalModels
{
    public class ActionPermissionModel
    {
        public bool IsValidURL { get; set; } = false;
        public bool IsCreate { get; set; } = false;
        public bool IsRead { get; set; } = false;
        public bool IsUpdate { get; set; } = false;
        public bool IsDelete { get; set; } = false;
        public bool IsDownload { get; set; } = false;
        public bool Export { get; set; } = false;
    }
}
