using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Login.Models;

public partial class LoginCredentialsContext : DbContext
{
    public LoginCredentialsContext()
    {
    }

    public LoginCredentialsContext(DbContextOptions<LoginCredentialsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=192.168.0.13\\\\\\\\sqlexpress,49753; Database=LoginCredentials; User Id=sa; Password=sa@12345678; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC0763EB4C5B");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E403235957").IsUnique();

            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
