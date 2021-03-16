using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class TempleDbContext : DbContext
    {
        public TempleDbContext(DbContextOptions<TempleDbContext> options) : base(options)
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<AvailableTime> AvailableTimes { get; set; }
    }
}
