using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class HealthLoggerDbContext : DbContext
    {

        public HealthLoggerDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
