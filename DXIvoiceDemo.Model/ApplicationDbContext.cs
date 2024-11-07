using DXIvoiceDemo.Model.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXIvoiceDemo.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfiguracja encji Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Code).HasMaxLength(50);
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.City).HasMaxLength(100);
                entity.Property(e => e.Country).HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(100);
            });

            // Konfiguracja encji Invoice
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.Id); // Klucz główny
                entity.Property(e => e.Number).IsRequired().HasMaxLength(50);
                entity.Property(e => e.SaleDate).IsRequired();
                entity.Property(e => e.TotalNet).HasColumnType("decimal(18,2)");
                entity.Property(e => e.VatRate).IsRequired();
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Currency).IsRequired().HasMaxLength(3);

                // Konfiguracja relacji wiele-do-jednego między Invoice i Customer
                entity.HasOne(e => e.Customer)
                    .WithMany() // Customer może mieć wiele Invoice
                    .HasForeignKey(e => e.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade); // Usunięcie Customer usuwa powiązane Invoice
            });
        }
    }
}