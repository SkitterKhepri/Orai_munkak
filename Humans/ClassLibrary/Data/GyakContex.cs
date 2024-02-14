using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class GyakContex : DbContext
    {
        public GyakContex()
        {
        }


        public DbSet<ClassLibrary.Models.Human> Human { get; set; } = default!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GyakAPI.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }


}
