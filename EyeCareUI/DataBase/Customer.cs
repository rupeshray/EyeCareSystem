using System;
using System.Collections.Generic;

namespace EyeCareUI.DataBase;

public partial class Customer
{
    public long Id { get; set; }

    public int IdCompany { get; set; }

    public int? IdBranch { get; set; }

    public int? IdDepartment { get; set; }

    public string CustomerId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? Email { get; set; }

    public string Mobile { get; set; } = null!;

    public int CustomerAge { get; set; }

    public string? CustomerAddress { get; set; }

    public int FollowupCount { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string ClientIp { get; set; } = null!;

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual Branch? IdBranchNavigation { get; set; }

    public virtual Company IdCompanyNavigation { get; set; } = null!;

    public virtual Department? IdDepartmentNavigation { get; set; }

    public virtual Employee? UpdatedByNavigation { get; set; }
}
