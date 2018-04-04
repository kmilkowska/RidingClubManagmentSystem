using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RidingClubMS.ViewModels;
using RidingClubMS.BLL.Entities;

namespace RidingClubMS.DAL.EF
{
    public class ApplicationDbContext<TUser, TRole, TKey> : IdentityDbContext<TUser, TRole, TKey>
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
    {
        private readonly ConnectionStringDto _connectionStringDto;

        // Table properties e.g
        // public virtual DbSet<Entity> TableName { get; set; }

        public virtual DbSet<Horse> Horses { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
        public virtual DbSet<UserRide> UserRides { get; set; }



        public ApplicationDbContext(ConnectionStringDto connectionStringDto)
        {
            _connectionStringDto = connectionStringDto;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionStringDto.ConnectionString); // for provider SQL Server 
            // optionsBuilder.UseMySql(_connectionStringDto.ConnectionString); //for provider My SQL 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRide>().HasKey(ur => new { ur.RideId, ur.UserId });


            modelBuilder.Entity<UserRide>()
               .HasOne(bc => bc.Ride)
               .WithMany(b => b.Users)
               .HasForeignKey(bc => bc.RideId);

            modelBuilder.Entity<UserRide>()
               .HasOne(bc => bc.User)
               .WithMany(b => b.UserRides)
               .HasForeignKey(bc => bc.UserId);
            // Fluent API commands
        }
    }
}