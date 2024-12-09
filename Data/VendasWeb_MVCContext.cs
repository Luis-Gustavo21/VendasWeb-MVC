using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasWeb_MVC.Models;

namespace VendasWeb_MVC.Data
{
    public class VendasWeb_MVCContext : DbContext
    {
        public VendasWeb_MVCContext (DbContextOptions<VendasWeb_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
