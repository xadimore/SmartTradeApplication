using Microsoft.EntityFrameworkCore;
using SmartTrade.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTrade.Services
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options)
        {

        }

        public DbSet<Price> Prices { get; set; }
        public DbSet<PriceHistory> PriceHistories { get; set; }
    }
}
