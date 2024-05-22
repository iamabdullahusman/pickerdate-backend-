using ag_grid.Models;
using Microsoft.EntityFrameworkCore;

namespace ag_grid.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }

    }
}
