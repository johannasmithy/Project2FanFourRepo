using Microsoft.EntityFrameworkCore;
using Project2.Models;

namespace Project2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users {get;set;}
        public DbSet<SavedTrip> SavedTrips {get;set;}
        public DbSet<Trip> Trips {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.SavedTrips)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Trip>()
                .HasMany(t => t.SavedTrips)
                .WithOne(s => s.Trip)
                .HasForeignKey(s => s.TripId);
        }
    }
}