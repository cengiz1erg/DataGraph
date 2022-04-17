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
        public DbSet<CurrencyPro> Currencies { get; set; }
    }
}
