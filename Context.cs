using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class Context : DbContext
    {
        public Context():base("cementDB") { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Cement> Cements { get; set; }
        public DbSet<Production> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Shift> Shifts { get; set; }
    }
}
