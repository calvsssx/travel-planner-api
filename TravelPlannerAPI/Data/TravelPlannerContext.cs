using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TravelPlannerAPI.Models;

namespace TravelPlannerAPI.Data
{
	public class TravelPlannerContext: DbContext
	{
        public TravelPlannerContext(DbContextOptions<TravelPlannerContext> options)
        : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<DestinationModel> Destinations { get; set; }
        public DbSet<TripModel> Trips { get; set; }
        public DbSet<TripDestinationModel> TripDestinations { get; set; }
        public DbSet<ActivityModel> Activities { get; set; }
        public DbSet<DestinationActivityModel> DestinationActivities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TripDestinationModel>()
            .HasKey(td => new { td.TripId, td.DestinationId });

            modelBuilder.Entity<TripDestinationModel>()
                .HasOne(td => td.Trip)
                .WithMany(t => t.TripDestinations)
                .HasForeignKey(td => td.TripId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TripDestinationModel>()
                .HasOne(td => td.Destination)
                .WithMany(d => d.TripDestinations)
                .HasForeignKey(td => td.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DestinationActivityModel>()
                .HasKey(da => new { da.DestinationId, da.ActivityId });

            modelBuilder.Entity<DestinationActivityModel>()
                .HasOne(da => da.Destination)
                .WithMany(d => d.DestinationActivities)
                .HasForeignKey(da => da.DestinationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DestinationActivityModel>()
                .HasOne(da => da.Activity)
                .WithMany(a => a.DestinationActivities)
                .HasForeignKey(da => da.ActivityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

