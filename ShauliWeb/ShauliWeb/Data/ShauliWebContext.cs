using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShauliWeb.Models
{
    public class ShauliWebContext : DbContext
    {
        public ShauliWebContext (DbContextOptions<ShauliWebContext> options)
            : base(options)
        {
        }

        public DbSet<ShauliWeb.Models.Comment> Comment { get; set; }
    }
}
