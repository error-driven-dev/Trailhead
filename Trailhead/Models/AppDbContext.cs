using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.EntityFrameworkCore;
using Trailhead.Models.API;

namespace Trailhead.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        
        public DbSet<NationalPark> NationalParks { get; set; }
        
    }
}
