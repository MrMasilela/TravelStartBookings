using Microsoft.EntityFrameworkCore;
using TravelStartBookings.Models.Entities;

namespace TravelStartBookings.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Amenity> Amneties { get; set; }        
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
