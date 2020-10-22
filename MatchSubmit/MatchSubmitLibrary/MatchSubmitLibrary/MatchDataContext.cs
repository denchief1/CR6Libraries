using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MatchSubmitLibrary.MatchRecord;

namespace MatchSubmitLibrary
{
    public class MatchDataContext : DbContext
    {
        public DbSet<MatchRecordModel> MatchRecord { get; set; }
        //public DbSet<MatchList> MatchList { get; set; }
        //public DbSet<MatchesWithNames> MatchesWithNames { get; set; }
        //public DbSet<MapOverviewData> MapOverview { get; set; }
        //public DbSet<MapResult> MapResult { get; set; }
        //public DbSet<Maps> Maps { get; set; }
        //public DbSet<CurrentWeek> CurrentWeek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.185.7.120;Database=cr6admin_ActiveSeason;Integrated Security=false;User ID=cr6admin_website;Password=Awesome1!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MatchRecordModel>().ToTable("MatchRecord").Property(p => p.ID).ValueGeneratedOnAdd();
            /*modelBuilder.Entity<MatchList>().ToTable("WeeklyMatches");
            modelBuilder.Entity<MatchesWithNames>().ToView("MatchesWithNames").HasNoKey();
            modelBuilder.Entity<MapOverviewData>().ToTable("MapOverview").Property(p => p.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<MapResult>().ToTable("MapResult").Property(p => p.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Maps>().ToView("Maps");
            modelBuilder.Entity<CurrentWeek>().ToTable("CurrentWeek");*/
        }
    }
}
