using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Data.Models;

namespace Portfolio.Data.Services
{
    public class PortfolioDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
