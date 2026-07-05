using System;
using System.Collections.Generic;

namespace EyeCareUI.DataBase;

public partial class Department
{
    public int Id { get; set; }

    public int IdCompany { get; set; }

    public int? IdBranch { get; set; }

    public string DepartmentName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string ClientIp { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Branch? IdBranchNavigation { get; set; }

    public virtual Company IdCompanyNavigation { get; set; } = null!;
}
