using System;
using System.Collections.Generic;

namespace EyeCareUI.DataBase;

public partial class SystemNavigation
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

    public bool IsActive { get; set; }

    public string? Cssclass { get; set; }

    public string? CsssubClass { get; set; }

    public string? Cssicon { get; set; }

    public string? CsssubIcon { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string ClientIp { get; set; } = null!;

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual Employee? UpdatedByNavigation { get; set; }
}
