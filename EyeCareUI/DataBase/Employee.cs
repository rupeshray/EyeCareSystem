using System;
using System.Collections.Generic;

namespace EyeCareUI.DataBase;

public partial class Employee
{
    public int Id { get; set; }

    public int IdCompany { get; set; }

    public int? IdBranch { get; set; }

    public int? IdDepartment { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string EmployeeGender { get; set; } = null!;

    public string EmployeeMobile { get; set; } = null!;

    public string? EmployeeEmail { get; set; }

    public string? Designation { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string ClientIp { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string LoginPassword { get; set; } = null!;

    public virtual ICollection<Customer> CustomerCreatedByNavigations { get; set; } = new List<Customer>();

    public virtual ICollection<Customer> CustomerUpdatedByNavigations { get; set; } = new List<Customer>();

    public virtual Branch? IdBranchNavigation { get; set; }

    public virtual Company IdCompanyNavigation { get; set; } = null!;

    public virtual Department? IdDepartmentNavigation { get; set; }

    public virtual ICollection<SystemNavigation> SystemNavigationCreatedByNavigations { get; set; } = new List<SystemNavigation>();

    public virtual ICollection<SystemNavigation> SystemNavigationUpdatedByNavigations { get; set; } = new List<SystemNavigation>();
}
