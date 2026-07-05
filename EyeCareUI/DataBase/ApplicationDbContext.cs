using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EyeCareUI.DataBase;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<SystemErrorRecord> SystemErrorRecords { get; set; }

    public virtual DbSet<SystemNavigation> SystemNavigations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branch__3214EC079EE5A6A1");

            entity.ToTable("Branch");

            entity.Property(e => e.BranchAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BranchPan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BranchPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BranchVat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BranchVAT");
            entity.Property(e => e.ClientIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("127.0.0.1")
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdCompanyNavigation).WithMany(p => p.Branches)
                .HasForeignKey(d => d.IdCompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Branch__IdCompan__571DF1D5");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Company__3214EC07497201BB");

            entity.ToTable("Company");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("127.0.0.1")
                .HasColumnName("ClientIP");
            entity.Property(e => e.CompanyAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CompanyPan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyPhone)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyVat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CompanyVAT");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC0779A5CB18");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("127.0.0.1")
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerAddress).HasMaxLength(500);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("M")
                .IsFixedLength();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Mobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Customers__Creat__71D1E811");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK__Customers__IdBra__6C190EBB");

            entity.HasOne(d => d.IdCompanyNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.IdCompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Customers__IdCom__6B24EA82");

            entity.HasOne(d => d.IdDepartmentNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.IdDepartment)
                .HasConstraintName("FK__Customers__IdDep__6D0D32F4");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CustomerUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Customers__Updat__72C60C4A");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC07B85F4EF2");

            entity.ToTable("Department");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("127.0.0.1")
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK__Departmen__IdBra__5CD6CB2B");

            entity.HasOne(d => d.IdCompanyNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.IdCompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Departmen__IdCom__5BE2A6F2");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07DBA1DFB4");

            entity.ToTable("Employee");

            entity.Property(e => e.ClientIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("127.0.0.1")
                .HasColumnName("ClientIP");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeEmail).HasMaxLength(500);
            entity.Property(e => e.EmployeeGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("M")
                .IsFixedLength();
            entity.Property(e => e.EmployeeMobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK__Employee__IdBran__628FA481");

            entity.HasOne(d => d.IdCompanyNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdCompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employee__IdComp__619B8048");

            entity.HasOne(d => d.IdDepartmentNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdDepartment)
                .HasConstraintName("FK__Employee__IdDepa__6383C8BA");
        });

        modelBuilder.Entity<SystemErrorRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SystemErrorRecord");

            entity.Property(e => e.Area)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ClientIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.Controller)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExceptionType).IsUnicode(false);
            entity.Property(e => e.MessageInfo).IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<SystemNavigation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SystemNa__3214EC07099C82FB");

            entity.ToTable("SystemNavigation");

            entity.Property(e => e.ActionName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClientIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ClientIP");
            entity.Property(e => e.Controller)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Cssclass)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CSSClass");
            entity.Property(e => e.Cssicon)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CSSIcon");
            entity.Property(e => e.CsssubClass)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CSSSubClass");
            entity.Property(e => e.CsssubIcon)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CSSSubIcon");
            entity.Property(e => e.Navigation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SystemNavigationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SystemNav__Creat__7D439ABD");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.SystemNavigationUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__SystemNav__Updat__7E37BEF6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
