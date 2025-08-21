using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Concretes;
using DataAccess.Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DataAccess.Context
{
    public class BilgeHotelContext:IdentityDbContext<AppUser, AppUserRole, string>
    {
        public BilgeHotelContext()
        {

        }
        public BilgeHotelContext(DbContextOptions<BilgeHotelContext> options) : base(options)
        {
        }
        //DbSet concretes içinde ki tüm sınıfları yap
        public DbSet<Staff> Staffs { get; set; } 
        public DbSet<Room> Rooms { get; set; } 
        public DbSet<ShiftTemplate> ShiftTemplates { get; set; } 
        public DbSet<RoomBlock> RoomBlocks { get; set; } 
        public DbSet<RoomType> RoomTypes { get; set; } 
        public DbSet<Reservation> Reservations { get; set; } 
        public DbSet<BoardType> BoardTypes { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<EarlyBookingRule> EarlyBookingRules { get; set; }
        public DbSet<RatePlan> RatePlans { get; set; }
        public DbSet<ShiftAssignment> ShiftAssignments { get; set; }

        //modelbuilder ı yap 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.Entity<Room>().ToTable("Rooms");
            modelBuilder.Entity<ShiftTemplate>().ToTable("ShiftTemplates");
            modelBuilder.Entity<RoomBlock>().ToTable("RoomBlocks");
            modelBuilder.Entity<RoomType>().ToTable("RoomTypes");
            modelBuilder.Entity<Reservation>().ToTable("Reservations");
            modelBuilder.Entity<BoardType>().ToTable("BoardTypes");
            modelBuilder.Entity<Guest>().ToTable("Guests");
            modelBuilder.Entity<Charge>().ToTable("Charges");
            modelBuilder.Entity<EarlyBookingRule>().ToTable("EarlyBookingRules");
            modelBuilder.Entity<RatePlan>().ToTable("RatePlans");
            modelBuilder.Entity<ShiftAssignment>().ToTable("ShiftAssignments");
            base.OnModelCreating(modelBuilder); 
        }


    }
}
