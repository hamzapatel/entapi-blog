using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlogSiteAPI.Respository.Models;

public partial class TechblogsContext : DbContext
{
    //Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=techblogs;Integrated Security=SSPI;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Project BlogSiteAPI.Respository
    public TechblogsContext()
    {
    }

    public TechblogsContext(DbContextOptions<TechblogsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=techblogs;Integrated Security=SSPI;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.ToTable("blogs");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Authorname)
                .HasMaxLength(50)
                .HasColumnName("authorname");
            entity.Property(e => e.Blogname)
                .HasMaxLength(50)
                .HasColumnName("blogname");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("createdDate");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
