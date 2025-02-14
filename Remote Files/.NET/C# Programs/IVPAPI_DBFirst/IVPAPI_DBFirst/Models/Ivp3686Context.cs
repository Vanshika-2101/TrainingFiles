using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IVPAPI_DBFirst.Models;

public partial class Ivp3686Context : DbContext
{
    public Ivp3686Context()
    {
    }

    public Ivp3686Context(DbContextOptions<Ivp3686Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<Auditbank> Auditbanks { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Creditcard> Creditcards { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Empview> Empviews { get; set; }

    public virtual DbSet<Groupa> Groupas { get; set; }

    public virtual DbSet<Groupb> Groupbs { get; set; }

    public virtual DbSet<Hod> Hods { get; set; }

    public virtual DbSet<Homeloan> Homeloans { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<NewBank> NewBanks { get; set; }

    public virtual DbSet<ProdBank> ProdBanks { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Product1> Products1 { get; set; }

    public virtual DbSet<Stream> Streams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Student1> Students1 { get; set; }

    public virtual DbSet<VuAnswer> VuAnswers { get; set; }

    public virtual DbSet<VuEmpManagegr> VuEmpManagegrs { get; set; }

    public virtual DbSet<Vucurrentaccount> Vucurrentaccounts { get; set; }

    public virtual DbSet<Vuempdept> Vuempdepts { get; set; }

    public virtual DbSet<Vujointaccount> Vujointaccounts { get; set; }

    public virtual DbSet<Vupremiumcustomer> Vupremiumcustomers { get; set; }

    public virtual DbSet<Vusavingaccount> Vusavingaccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=192.168.0.13\\\\\\\\sqlexpress,49753; Database=IVP3686; User Id=sa; Password=sa@12345678; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("Admin_ID_PK");

            entity.ToTable("Administrator", "MiniProject");

            entity.HasIndex(e => e.AdminContact, "Admin_Contact_UK").IsUnique();

            entity.HasIndex(e => e.AdminEmail, "Admin_Email_UK").IsUnique();

            entity.HasIndex(e => e.UserId, "Admin_UserID_UK").IsUnique();

            entity.Property(e => e.AdminId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AdminID");
            entity.Property(e => e.AdminContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdminEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdminName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Auditbank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUDITBANK");

            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Newacctype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NEWACCTYPE");
            entity.Property(e => e.Newbal).HasColumnName("NEWBAL");
            entity.Property(e => e.Oldacctype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OLDACCTYPE");
            entity.Property(e => e.Oldbal).HasColumnName("OLDBAL");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
            entity.Property(e => e.Xndate)
                .HasColumnType("datetime")
                .HasColumnName("XNDATE");
            entity.Property(e => e.Xntype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("XNTYPE");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__BANK__C1F8DC590AB38F0F");

            entity.ToTable("BANK", tb =>
                {
                    tb.HasTrigger("TRGAUDITDELETE");
                    tb.HasTrigger("TRGAUDITINSERT");
                    tb.HasTrigger("TRGAUDITUPDATE");
                });

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.Acctype)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Balance);
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("INDIA")
                .HasColumnName("COUNTRY");
        });

        modelBuilder.Entity<Creditcard>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__CREDITCA__C1F8DC59E15223BA");

            entity.ToTable("CREDITCARD");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARDTYPE");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
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

        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__DEPT__C03656300EF7408F");

            entity.ToTable("DEPT");

            entity.Property(e => e.Did)
                .ValueGeneratedNever()
                .HasColumnName("DID");
            entity.Property(e => e.Dname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DNAME");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("EMP_EID_PK");

            entity.ToTable("EMP");

            entity.HasIndex(e => e.Aadharcard, "EMP_AC_UK").IsUnique();

            entity.HasIndex(e => e.Email, "EMP_MAIL_UK").IsUnique();

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("EID");
            entity.Property(e => e.Aadharcard)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("AADHARCARD");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("INDIA")
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Did).HasColumnName("DID");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GENDER");
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Salary).HasColumnName("SALARY");

            entity.HasOne(d => d.DidNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Did)
                .HasConstraintName("EMP_DID_FK");

            entity.HasOne(d => d.MidNavigation).WithMany(p => p.InverseMidNavigation)
                .HasForeignKey(d => d.Mid)
                .HasConstraintName("EMP_MID_FK");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("EMP_EMP_ID_PK");

            entity.ToTable("EMPLOYEES");

            entity.HasIndex(e => e.DepartmentId, "EMPLOYEES_DEPARTMENT_ID_NCI");

            entity.HasIndex(e => new { e.LastName, e.JobId, e.HireDate }, "EMPLOYEES_LN_JI_HD_NCI");

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

        modelBuilder.Entity<Empview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMPVIEW");

            entity.Property(e => e.CommissionPct).HasColumnName("COMMISSION_PCT");
            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
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
        });

        modelBuilder.Entity<Groupa>(entity =>
        {
            entity.HasKey(e => e.Teamid).HasName("PK__GROUPA__966C5F75C7E80A5D");

            entity.ToTable("GROUPA");

            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<Groupb>(entity =>
        {
            entity.HasKey(e => e.Teamid).HasName("PK__GROUPB__966C5F7572185C58");

            entity.ToTable("GROUPB");

            entity.Property(e => e.Teamid).HasColumnName("TEAMID");
            entity.Property(e => e.Teamname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEAMNAME");
        });

        modelBuilder.Entity<Hod>(entity =>
        {
            entity.HasKey(e => e.Hodid).HasName("HOD_ID_PK");

            entity.ToTable("HOD", "MiniProject");

            entity.HasIndex(e => e.Email, "HOD_Email_UK").IsUnique();

            entity.Property(e => e.Hodid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HODID");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Stream).WithMany(p => p.Hods)
                .HasForeignKey(d => d.StreamId)
                .HasConstraintName("HOD_StreamID_FK");
        });

        modelBuilder.Entity<Homeloan>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__HOMELOAN__C1F8DC59B1F03504");

            entity.ToTable("HOMELOAN");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
            entity.Property(e => e.Loantype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOANTYPE");
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

        modelBuilder.Entity<NewBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NEW_BANK");

            entity.Property(e => e.Acctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCTYPE");
            entity.Property(e => e.Balance).HasColumnName("BALANCE");
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
        });

        modelBuilder.Entity<ProdBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROD_BANK");

            entity.Property(e => e.Acctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCTYPE");
            entity.Property(e => e.Balance).HasColumnName("BALANCE");
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRODUCT");

            entity.HasIndex(e => e.Pcategory, "PRODUCT_PCAT_NCI");

            entity.Property(e => e.Pcategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PCATEGORY");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PNAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
        });

        modelBuilder.Entity<Product1>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__PRODUCT__C5775520953F54A2");

            entity.ToTable("PRODUCT", "SALES");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PID");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PNAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
        });

        modelBuilder.Entity<Stream>(entity =>
        {
            entity.HasKey(e => e.StreamId).HasName("Stream_StreamID_PK");

            entity.ToTable("Stream", "MiniProject");

            entity.Property(e => e.StreamId).HasColumnName("StreamID");
            entity.Property(e => e.StreamName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.HasIndex(e => new { e.Branch, e.Marks }, "Student_Branch_Marks_NCI");

            entity.HasIndex(e => e.Branch, "Student_Branch_NCI");

            entity.HasIndex(e => new { e.Marks, e.Branch }, "Student_Marks_Branch_NCI");

            entity.HasIndex(e => e.Marks, "Student_Marks_NCI");

            entity.HasIndex(e => e.Sid, "Student_SID_UCI")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.Sname, e.Marks }, "Student_SName_Marks_NCI");

            entity.HasIndex(e => e.Sname, "Student_SName_NCI");

            entity.Property(e => e.Branch)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SName");
        });

        modelBuilder.Entity<Student1>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("Student_SID_PK");

            entity.ToTable("Student", "MiniProject");

            entity.HasIndex(e => e.Email, "Student_Email_UK").IsUnique();

            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Grade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StreamId).HasColumnName("StreamID");

            entity.HasOne(d => d.Stream).WithMany(p => p.Student1s)
                .HasForeignKey(d => d.StreamId)
                .HasConstraintName("Student_StreamID_FK");
        });

        modelBuilder.Entity<VuAnswer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VU_ANSWER");

            entity.Property(e => e.Avgsal).HasColumnName("AVGSAL");
            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("DEPARTMENT_NAME");
            entity.Property(e => e.Totalsal).HasColumnName("TOTALSAL");
        });

        modelBuilder.Entity<VuEmpManagegr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VU_EMP_MANAGEGR");

            entity.Property(e => e.EmpName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EMP_NAME");
            entity.Property(e => e.EmpNum).HasColumnName("EMP_NUM");
            entity.Property(e => e.ManName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MAN_NAME");
            entity.Property(e => e.ManNum).HasColumnName("MAN_NUM");
        });

        modelBuilder.Entity<Vucurrentaccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VUCURRENTACCOUNT");

            entity.Property(e => e.Acctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCTYPE");
            entity.Property(e => e.Balance).HasColumnName("BALANCE");
            entity.Property(e => e.Cid).HasColumnName("CID");
        });

        modelBuilder.Entity<Vuempdept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VUEMPDEPT");

            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("DEPARTMENT_NAME");
            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(46)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEE_NAME");
            entity.Property(e => e.HireDate)
                .HasColumnType("datetime")
                .HasColumnName("HIRE_DATE");
            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("JOB_ID");
            entity.Property(e => e.Salary).HasColumnName("SALARY");
        });

        modelBuilder.Entity<Vujointaccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VUJOINTACCOUNT");

            entity.Property(e => e.Acctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCTYPE");
            entity.Property(e => e.Balance).HasColumnName("BALANCE");
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
        });

        modelBuilder.Entity<Vupremiumcustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VUPREMIUMCUSTOMERS");

            entity.Property(e => e.Acctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCTYPE");
            entity.Property(e => e.Balance).HasColumnName("BALANCE");
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
        });

        modelBuilder.Entity<Vusavingaccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VUSAVINGACCOUNT");

            entity.Property(e => e.Acctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCTYPE");
            entity.Property(e => e.Balance).HasColumnName("BALANCE");
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
