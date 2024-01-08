using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using todoDolog.Models;

namespace todoDolog.Data
{
    public class todoDologContext : DbContext
    {
        public todoDologContext (DbContextOptions<todoDologContext> options)
            : base(options)
        {
        }

        public DbSet<todoDolog.Models.Todo> Todo { get; set; } = default!;
    }
}
