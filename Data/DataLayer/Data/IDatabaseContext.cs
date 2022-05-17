using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public interface IDatabaseContext
    {
        public DbSet<ApplicationUser> Users { get; set; }
    }
}
