using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app5.models
{
   // [System.Data.Entity.DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Customer> CustomerTB { get; set; }
    }
}
