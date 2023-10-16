using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Models
{
    public partial class XeKhachModel : DbContext
    {
        public XeKhachModel()
            : base("name=XeKhachModel3")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<CoachType> CoachTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LogInAccount> LogInAccounts { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripInf> TripInfs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.Seat)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.CustomerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.TripID)
                .IsUnicode(false);

            modelBuilder.Entity<Coach>()
                .Property(e => e.CoachId)
                .IsUnicode(false);

            modelBuilder.Entity<Coach>()
                .Property(e => e.CoachPlate)
                .IsUnicode(false);

            modelBuilder.Entity<CoachType>()
                .HasMany(e => e.Coaches)
                .WithRequired(e => e.CoachType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoachType>()
                .HasMany(e => e.TripInfs)
                .WithRequired(e => e.CoachType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeId)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.LogInAccounts)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogInAccount>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<LogInAccount>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<LogInAccount>()
                .Property(e => e.EmployeeId)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.TripID)
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .HasMany(e => e.TripInfs)
                .WithRequired(e => e.Trip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TripInf>()
                .Property(e => e.TripID)
                .IsUnicode(false);

            modelBuilder.Entity<TripInf>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.TripInf)
                .HasForeignKey(e => new { e.TypeId, e.TripID })
                .WillCascadeOnDelete(false);
        }
    }
}
