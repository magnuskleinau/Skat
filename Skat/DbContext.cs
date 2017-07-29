﻿using System;
using Microsoft.EntityFrameworkCore;
namespace Skat
{
    public class SkatContext : DbContext
    {
        public DbSet<Abend> abende { get; set; }
        public DbSet<Spiel> spiele { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }
    }
}