using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using todoWebApp.Models;

namespace todoWebApp.Data
{
    public class todoWebAppContext : DbContext
    {
        public todoWebAppContext (DbContextOptions<todoWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<todoWebApp.Models.todo> todo { get; set; } = default!;
    }
}
