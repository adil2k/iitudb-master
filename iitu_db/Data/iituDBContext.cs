using System;
using iitu_db.Models;
using Microsoft.EntityFrameworkCore;

namespace iitu_db.Data
{
    public class iituDBContext : DbContext
    {
        public iituDBContext(DbContextOptions<iituDBContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Competition> Competition { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>()
            .HasOne(b => b.Team)
            .WithOne(i => i.Trainer)
            .HasForeignKey<Team>(b => b.TrainerId);

            modelBuilder.Entity<TeamCompetition>()
            .HasKey(t => new { t.TeamId, t.CompetitionId });

            modelBuilder.Entity<TeamCompetition>()
                .HasOne(pt => pt.Team)
                .WithMany(p => p.TeamCompetitions)
                .HasForeignKey(pt => pt.TeamId);

            modelBuilder.Entity<TeamCompetition>()
                .HasOne(pt => pt.Competition)
                .WithMany(t => t.TeamCompetitions)
                .HasForeignKey(pt => pt.CompetitionId);

            modelBuilder.Entity<Player>()
            .HasOne(p => p.Team)
            .WithMany(b => b.Player);
        }
    }
}
