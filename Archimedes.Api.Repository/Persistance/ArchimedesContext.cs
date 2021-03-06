﻿using Microsoft.EntityFrameworkCore;

namespace Archimedes.Api.Repository
{
    public class ArchimedesContext : DbContext
    {
        public DbSet<Price> Prices { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Candle> Candles { get; set; }
        public ArchimedesContext(DbContextOptions<ArchimedesContext> options) : base(options)
        {
        }
    }
}