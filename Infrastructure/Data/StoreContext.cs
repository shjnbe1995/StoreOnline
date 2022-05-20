using Core.Identities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) 
        { 

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
