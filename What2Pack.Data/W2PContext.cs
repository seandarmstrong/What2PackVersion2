using Microsoft.EntityFrameworkCore;
using What2Pack.Domain.EntityModels;

namespace What2Pack.Data
{
    public class W2PContext : DbContext
    {
        public W2PContext()
        {

        }

        public DbSet<TripItem> Items { get; set; }
        public DbSet<PackedItem> PackedItems { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
