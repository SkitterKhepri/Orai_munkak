using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace GyakAPI.Data
{
    public class GyakAPIContext : DbContext
    {
        public GyakAPIContext (DbContextOptions<GyakAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Human> Human { get; set; } = default!;
    }
}
