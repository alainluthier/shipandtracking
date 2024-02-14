using Microsoft.EntityFrameworkCore;
using ShipAndTrack.Models;
namespace ShipAndTrack.Data
{
    public class ShipAndTrackContext : DbContext{
        public ShipAndTrackContext(DbContextOptions<ShipAndTrackContext> options)
        : base(options){

        }
        public DbSet<User> Users {get;set;}
        public DbSet<Address> Addresses {get;set;}
        public DbSet<Tracking> Trackings {get;set;}
        public DbSet<Package> Packages {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<Address>().ToTable("Address");
        modelBuilder.Entity<Tracking>().ToTable("Tracking");
        modelBuilder.Entity<Package>().ToTable("Package");
    }
    }
}