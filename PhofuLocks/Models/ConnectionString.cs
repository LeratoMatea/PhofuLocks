using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhofuLocks.Models
{
    public class ConnectionStringClass: DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options):base(options)
        {

        }

        public DbSet<CarsClass> Cars { get; set; }


    }
}
