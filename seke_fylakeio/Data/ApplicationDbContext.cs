using Microsoft.EntityFrameworkCore;
using seke_fylakeio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seke_fylakeio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Zygisma> Zygisma { get; set; }
    }
}
