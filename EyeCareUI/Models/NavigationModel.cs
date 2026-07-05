namespace EyeCareUI.Models
{
    public class NavigationModel
    {
        public int Id { get; set; }

        public int? IdParent { get; set; }

        public string Navigation { get; set; } = null!;

        public string? Area { get; set; }

        public string? Controller { get; set; }

        public string? ActionName { get; set; }

        public int? ParentOrder { get; set; }

        public int? ChildOrder { get; set; }

        public bool IsMenu { get; set; }

        public bool IsTab { get; set; }

        public string? Cssclass { get; set; }

        public string? CsssubClass { get; set; }

        public string? Cssicon { get; set; }

        public string? CsssubIcon { get; set; }
    }
}
