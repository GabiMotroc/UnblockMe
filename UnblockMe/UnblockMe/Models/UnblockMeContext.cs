using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class UnblockMeContext : IdentityDbContext<User>
    {
        public UnblockMeContext()
        {
        }

        public UnblockMeContext(DbContextOptions<UnblockMeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car{ get; set; }

        public virtual DbSet<User> ApplicationUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Password=test;Persist Security Info=True;User ID=test;Initial Catalog=UnblockMe;Data Source=192.168.0.176, 1433");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.LicencePlate)
                    .HasName("PK__car__1771C83C7CEAA648");

                entity.ToTable("car");

                entity.Property(e => e.LicencePlate)
                    .HasColumnName("licencePlate")
                    .HasMaxLength(20);

                entity.Property(e => e.Blocks)
                    .HasColumnName("blocks")
                    .HasMaxLength(20);

                entity.Property(e => e.BockedBy)
                    .HasColumnName("bockedBy")
                    .HasMaxLength(20);

                entity.Property(e => e.Colour)
                    .HasColumnName("colour")
                    .HasMaxLength(20);

                entity.Property(e => e.Maker)
                    .HasColumnName("maker")
                    .HasMaxLength(30);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(20);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("ownerId");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_car_owner");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
