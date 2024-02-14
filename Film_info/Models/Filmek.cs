using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace Film_info.Models
{
    public class Filmek : DbContext
    {

        public Filmek(DbContextOptions<Filmek> options) :
            base(options)
        { }

        public DbSet<Film>? filmek {get; set;}



    }

}
