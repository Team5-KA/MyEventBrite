using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EventItem> EventItems { get; set; }

    /*  public DbSet<EventType> EventTypes { get; set; }

        public DbSet<EventCategory> EventCategories { get; set; }       */


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventItem>(e =>
            {
                e.ToTable("Event");
                e.Property(c => c.Id)
                    .IsRequired()
                    .UseHiLo("event_hilo");
                e.Property(c => c.Title)
                    .IsRequired()
                    .HasMaxLength(100);
                e.Property(c => c.Description)
                    .IsRequired()
                    .HasMaxLength(1000);
    /*          e.HasOne(c => c.EventType)
                    .WithMany()
                    .HasForeignKey(c => c.EventTypeId);
                e.HasOne(c => c.EventCategory)
                    .WithMany()
                    .HasForeignKey(c => c.EventCategoryId);         */

            });


    /*      modelBuilder.Entity<EventType>(e =>
            {
                e.ToTable("EventTypes");
                e.Property(t => t.Id)
                    .IsRequired()
                    .UseHiLo("event_types_hilo");

                e.Property(t => t.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EventCategory>(e =>
            {
                e.ToTable("EventCategories");
                e.Property(t => t.Id)
                    .IsRequired()
                    .UseHiLo("event_categories_hilo");

                e.Property(t => t.Category)
                    .IsRequired()
                    .HasMaxLength(100);
            });     */


        }
    }
}
