﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UnblockMe.Services;

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

        public virtual DbSet<BlockedUsers> BlockedUsers { get; set; }

        public virtual DbSet<Audit> AuditRecords { get; set; }

        public virtual DbSet<UserActivity> UserActivities { get; set; }

        public virtual DbSet<BlockingInteractions> BlockingInteractions { get; set; }

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

            modelBuilder.Entity<BlockedUsers>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_BlockedUsers");

                entity.ToTable("BlockedUsers");

                entity.Property(e => e.BlockedId)
                    .HasColumnName("BlockedId");

                entity.Property(e => e.StartTime)
                    .HasColumnName("StartTime");

                entity.Property(e => e.StopTime)
                    .HasColumnName("StopTime");

                entity.Property(e => e.Reason)
                    .HasColumnName("Reason");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.BlockedUser)
                    .HasForeignKey<BlockedUsers>(d => d.BlockedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlockedUsers");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasKey(e => e.AuditID)
                    .HasName("PK_Audit");

                entity.ToTable("Audit");

                entity.Property(e => e.UserName)
                    .HasColumnName("UserName");

                entity.Property(e => e.IPAddress)
                    .HasColumnName("IPAdress");

                entity.Property(e => e.AreaAccessed)
                    .HasColumnName("AreaAccessed");

                entity.Property(e => e.TimeAccessed)
                    .HasColumnName("TimeAccessed");

            });

            modelBuilder.Entity<UserActivity>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_UserActivities");

                entity.ToTable("UserActivities");

                entity.Property(e => e.Url)
                    .HasColumnName("Url");

                entity.Property(e => e.Data)
                    .HasColumnName("Data");

                entity.Property(e => e.UserName)
                    .HasColumnName("UserName");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("IpAddress");

                entity.Property(e => e.ActivityTime)
                    .HasColumnName("ActivityTime");

            });

            modelBuilder.Entity<BlockingInteractions>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_BlockingInteractions");

                entity.ToTable("BlockingInteractions");

                entity.Property(e => e.Stuck)
                    .HasColumnName("Stuck");

                entity.Property(e => e.BlockedBy)
                    .HasColumnName("BlockedBy");

                entity.Property(e => e.InteractionTime)
                    .HasColumnName("InteractionTime");

                entity.Property(e => e.Latitude)
                    .HasColumnName("Latitude");

                entity.Property(e => e.Longitude)
                    .HasColumnName("Longitude");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
