using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.EntityFramework
{
    public class NutShellDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(local);Database=DOTNET8;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name)
                .HasColumnName("Name")
                .IsRequired();
            });

            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.HasKey(e => new { e.ID, e.Name });
            //});

            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.Property(e => e.Name).HasMaxLength(30); //what will thorw if the length is more than 30
            //});

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasOne(e => e.Customer)
                      .WithMany(e => e.Purchases)
                      .HasForeignKey(e => e.CustomerID);
            });



        }
    }
}
