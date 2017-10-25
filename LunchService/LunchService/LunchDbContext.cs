using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LunchService
{
    public class LunchDbContext : DbContext
    {
        public LunchDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
