using System;
using System.Collections.Generic;

namespace EyeCareUI.DataBase;

public partial class Branch
{
    public int Id { get; set; }

    public int IdCompany { get; set; }

    public string BranchName { get; set; } = null!;

    public string? BranchAddress { get; set; }

    public string? BranchPhone { get; set; }

    public string? BranchPan { get; set; }

    public string? BranchVat { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string ClientIp { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Company IdCompanyNavigation { get; set; } = null!;
}
