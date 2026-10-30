using System;
using System.Collections.Generic;
using HotelBooking.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Data.Context;

public partial class HotelBookingDbContext : DbContext
{
    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hotels__3214EC07A31B0EA9");

            entity.ToTable("Hotel");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC077EB3DAA3");

            entity.ToTable("Role");

            entity.HasIndex(e => e.Name, "UQ__Roles__737584F6DF199BA5").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3214EC0706CFF47F");

            entity.ToTable("User");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.PasswordHash).HasMaxLength(200);

            entity.HasOne(d => d.Hotel).WithMany(p => p.Users)
                .HasForeignKey(d => d.HotelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__users__HotelId__5070F446");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__users__RoleId__5165187F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
