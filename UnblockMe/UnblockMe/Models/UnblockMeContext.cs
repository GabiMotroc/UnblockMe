using System;
using System.Threading.Tasks;
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

        public virtual DbSet<Car> Car { get; set; }

        public virtual DbSet<User> ApplicationUsers { get; set; }

        public virtual DbSet<CarPhoto> CarPhoto { get; set; }

        public virtual DbSet<BlockedUser> BlockedUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Password=test;Persist Security Info=True;User ID=test;Initial Catalog=UnblockMe;Data Source=192.168.0.176, 1433");
            }
        }

        internal Task AddAsync()
        {
            throw new NotImplementedException();
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

                entity.Property(e => e.PhotoId)
                    .HasColumnName("photoId");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_car_owner");

                entity.HasOne(d => d.Photo)
                    .WithOne(p => p.Car)
                    .HasForeignKey<Car>(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_car_photo");
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

            modelBuilder.Entity<CarPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PK_CarPhoto");

                entity.ToTable("CarPhoto");

                entity.Property(e => e.PhotoId)
                    .HasColumnName("photoId");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo");
            });

            modelBuilder.Entity<BlockedUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_BlockedUser");

                entity.ToTable("BlockedUser");

                entity.Property(e => e.StartTime)
                    .HasColumnName("StartTime");

                entity.Property(e => e.StopTime)
                    .HasColumnName("StopTime");

                entity.Property(e => e.Reason)
                    .HasColumnName("Reason");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.BlockedUser)
                    .HasForeignKey<BlockedUser>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Blocked_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
