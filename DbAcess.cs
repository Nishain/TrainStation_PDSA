using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
//using TrainStations.Migrations;
using TrainStations.Models;

namespace TrainStations.DAL
{
    public class DbAcess : DbContext
    {
        public DbAcess() : base("myconnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbAcess, Configuration>());
        }
        public DbSet<Stations> stations { get; set; }
        public DbSet<StationDistance> stationDistances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Stations>()
            .HasMany<StationDistance>(g => g.StationDistances1)
            .WithRequired(s => s.Stations1)
            .HasForeignKey<int>(s => s.Distance1)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stations>()
            .HasMany<StationDistance>(g => g.StationDistances2)
            .WithRequired(s => s.Stations2)
            .HasForeignKey<int>(s => s.Distance2)
            .WillCascadeOnDelete(false);
        }

    }
}