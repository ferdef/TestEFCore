using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestDB.Models;

namespace TestDB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PintxoVote>().HasKey(pv => new {pv.PintxoId, pv.VoterId});
            builder.Entity<WineVote>().HasKey(wv => new {wv.WineId, wv.VoterId});
        }

        public DbSet<Contest> Contests {get; set;}
        public DbSet<Family> Families {get; set;}
        public DbSet<User> Participants {get; set;}
        public DbSet<Pintxo> Pintxos {get; set;}
        public DbSet<PintxoVote> PintxoVotes {get; set;}
        public DbSet<Wine> Wines {get; set;}
        public DbSet<WineVote> WineVotes {get; set;}
        
    }
}
