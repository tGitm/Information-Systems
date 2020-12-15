using web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public class RestaurantContext : IdentityDbContext<ApplicationUser>
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Guest> Guests { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<Guest>().ToTable("Guest");
        }
    }
}