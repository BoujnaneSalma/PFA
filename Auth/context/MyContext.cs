using Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.context
{
    public class MyContext:DbContext
    {

        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Avis> Avis { get; set; }
        public DbSet<Chambres> Chambres { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Endroit> Endroits { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Itineraire> Itineraires { get; set; }
        public DbSet<LieuTour> LieuTours { get; set; }
        public DbSet<Paiment> Paiments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<Ville> Villes { get; set; }


    }
}
