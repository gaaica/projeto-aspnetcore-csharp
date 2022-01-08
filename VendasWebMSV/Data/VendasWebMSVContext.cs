using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasWebMSV.Models
{
    public class VendasWebMSVContext : DbContext
    {
        public VendasWebMSVContext (DbContextOptions<VendasWebMSVContext> options)
            : base(options)
        {
        }

        public DbSet<VendasWebMSV.Models.Department> Department { get; set; }
    }
}
