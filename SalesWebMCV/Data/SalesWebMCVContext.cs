using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMCV.Models;

namespace SalesWebMCV.Data
{
    public class SalesWebMCVContext : DbContext
    {
        public SalesWebMCVContext (DbContextOptions<SalesWebMCVContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
