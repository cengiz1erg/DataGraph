using Microsoft.EntityFrameworkCore;
using ProvisionSecond.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvisionSecond.Data
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyPro>()
                .HasIndex(c => c.Code); // Because code will be used for query. "/Currency/GetCurrency"
        }
        public DbSet<CurrencyPro> Currencies { get; set; }
    }
}
