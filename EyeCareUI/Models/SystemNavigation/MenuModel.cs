namespace EyeCareUI.Models.SystemNavigation
{
    public class MenuModel
    {
        public int IdSideNavigation { get; set; }
        public Nullable<int> IdParent { get; set; }
        public bool IsMenu { get; set; }
        public required string Menu { get; set; }
        public Nullable<int> ParentOrder { get; set; }
        public Nullable<int> ChildOrder { get; set; }
        public string CSSClass { get; set; } = string.Empty;
        public string CSSSubClass { get; set; } = string.Empty;
        public string CSSIcon { get; set; } = string.Empty;
        public string CSSSubIcon { get; set; } = string.Empty;
        public string DefaultURL { get; set; } = string.Empty;
        public string ParentStatusClass { get; set; } = string.Empty;
        public string StatusClass { get; set; } = string.Empty;
    }
}
