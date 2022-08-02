using Microsoft.EntityFrameworkCore;
using NooriEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NooriApplication.Data
{
    public class NooriDbContext : DbContext
    {
        public NooriDbContext(DbContextOptions<NooriDbContext> dbContextOptions): base(dbContextOptions)
        {
        }
        public DbSet<Users> users { get; set; }

    }
}
