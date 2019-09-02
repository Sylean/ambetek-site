using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ambetekSite.Models
{
    public class labTestContext : DbContext
    {
        public labTestContext (DbContextOptions<labTestContext> options)
            : base(options)
        {
        }

        public DbSet<ambetekSite.Models.labTest> labTest { get; set; }
    }
}
