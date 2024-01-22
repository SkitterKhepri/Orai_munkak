using Microsoft.EntityFrameworkCore;

namespace csaladfa_cs.Modellek
{
    public class Csaladfa : DbContext
    {
        public Csaladfa(DbContextOptions<Csaladfa> options) :base(options) {

        }

        public DbSet<Szemely> szemelyek { get; set; }
        public DbSet<Elhunyt> elhunytak { get; set;}

    }
}
