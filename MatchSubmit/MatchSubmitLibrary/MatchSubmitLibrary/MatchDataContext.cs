using MatchSubmitLibrary.MatchRecord;
using Microsoft.EntityFrameworkCore;

namespace MatchSubmitLibrary
{
    /// <summary>
    /// Implementation of DBContext for MatchDataSubmit Lib.
    /// </summary>
    public class MatchDataContext : DbContext
    {
        /// <summary>
        /// Gets or sets a DbSet of the MatchRecordModel.
        /// </summary>
        public DbSet<MatchRecordModel> MatchRecord { get; set; }
        /*public DbSet<MatchList> MatchList { get; set; }
        public DbSet<MatchesWithNames> MatchesWithNames { get; set; }
        public DbSet<MapOverviewData> MapOverview { get; set; }
        public DbSet<MapResult> MapResult { get; set; }
        public DbSet<Maps> Maps { get; set; }
        public DbSet<CurrentWeek> CurrentWeek { get; set; }*/

        /// <summary>
        /// Creates the connection to the SQL DB.
        /// </summary>
        /// <param name="optionsBuilder">Options configs for the DB connection.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.185.7.120;Database=cr6admin_ActiveSeason;Integrated Security=false;User ID=cr6admin_website;Password=Awesome1!");
        }

        /// <summary>
        /// Mapping of models to the SQL DB.
        /// </summary>
        /// <param name="modelBuilder">Models to map.</param>
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
