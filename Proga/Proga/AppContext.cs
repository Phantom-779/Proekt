using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Proga
{
    class AppContext : DbContext
    {
        public DbSet<Metestan> metestan { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
