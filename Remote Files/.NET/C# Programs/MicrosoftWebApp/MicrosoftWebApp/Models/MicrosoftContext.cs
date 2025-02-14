using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MicrosoftWebApp.Models;

public partial class MicrosoftContext : DbContext
{
    public MicrosoftContext()
    {
    }

    public MicrosoftContext(DbContextOptions<MicrosoftContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=192.168.0.13\\sqlexpress,49753; Database=Microsoft; User Id=sa; Password=sa@12345678; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__bank__C1F8DC5917224F01");

            entity.ToTable("bank");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("DEPT_ID_PK");

            entity.ToTable("DEPARTMENTS");

            entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("DEPARTMENT_NAME");
            entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("DEPT_MGR_FK");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("EMP_EMP_ID_PK");

            entity.ToTable("EMPLOYEES");

            entity.HasIndex(e => e.Email, "EMP_EMAIL_UK").IsUnique();

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.CommissionPct).HasColumnName("COMMISSION_PCT");
            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.HireDate)
                .HasColumnType("datetime")
                .HasColumnName("HIRE_DATE");
            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("JOB_ID");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.Salary).HasColumnName("SALARY");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("EMP_DEPT_FK");

            entity.HasOne(d => d.Job).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMP_JOB_FK");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("EMP_MANAGER_FK");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("JOBS_ID_PK");

            entity.ToTable("JOBS");

            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("JOB_ID");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .HasColumnName("JOB_TITLE");
            entity.Property(e => e.MaxSalary).HasColumnName("MAX_SALARY");
            entity.Property(e => e.MinSalary).HasColumnName("MIN_SALARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
