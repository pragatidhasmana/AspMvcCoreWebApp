using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AspMvcCoreWebApp.Models;

public partial class PragatidbContext : DbContext
{
    public PragatidbContext()
    {
    }

    public PragatidbContext(DbContextOptions<PragatidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Product> Products { get; set; }


    public virtual DbSet<Course> Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:newdb1.database.windows.net,1433;Initial Catalog=pragatidb;Persist Security Info=False;User ID=sqladmin;Password=Welcome@1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__C92D71A79632B2F6");

            entity.Property(e => e.CourseFee).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CourseName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
