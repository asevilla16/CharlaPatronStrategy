using Microsoft.EntityFrameworkCore;
using PatronEstrategia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Context
{
    public class CharactersContext : DbContext
    {
        public DbSet<Jedi> Jedis { get; set; }
        public DbSet<Sith> Siths { get; set; }
        public DbSet<Droid> Droids { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=DESKTOP-C2JN085; DataBase=StrategyExample; Trusted_Connection=True;");
        }
    }
}
