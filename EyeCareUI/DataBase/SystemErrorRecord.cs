using System;
using System.Collections.Generic;

namespace EyeCareUI.DataBase;

public partial class SystemErrorRecord
{
    public Guid Id { get; set; }

    public string? Area { get; set; }

    public string? Controller { get; set; }

    public string? ExceptionType { get; set; }

    public string? MessageInfo { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string ClientIp { get; set; } = null!;
}
