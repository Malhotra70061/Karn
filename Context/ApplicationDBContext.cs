using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karn.Modals;
using Microsoft.EntityFrameworkCore;

namespace Karn.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ) : base (options){ }
        public DbSet<BasicTaxCalculation> BasicTaxCalculation { get; set; }
        public DbSet<Calculation> Calculation { get; set; }
    }
}
