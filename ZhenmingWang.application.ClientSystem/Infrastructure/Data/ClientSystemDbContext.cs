using System.Collections.Generic;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class ClientSystemDbContext : DbContext
    {
        public ClientSystemDbContext(DbContextOptions<ClientSystemDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Interaction> Interactions { get; set; }

        // Many DbSets, they are represented as properties
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(ConfigureClient);
            modelBuilder.Entity<Employee>(ConfigureEmployee);
            modelBuilder.Entity<Interaction>(ConfigureInteraction);
        }

        private void ConfigureClient(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.Phones).HasMaxLength(30);
            builder.Property(c => c.Address).HasMaxLength(100);
            builder.Property(c => c.AddedOn).HasDefaultValueSql("getdate()");
        }

        private void ConfigureEmployee(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(50);
            builder.Property(e => e.Password).HasMaxLength(10);
            builder.Property(e => e.Designation).HasMaxLength(50);
        }

        private void ConfigureInteraction(EntityTypeBuilder<Interaction> builder)
        {
            builder.ToTable("Interactions");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.HasOne(c => c.Client).WithMany(i => i.Interactions).HasForeignKey(i => i.ClientId);
            builder.HasOne(e => e.Employee).WithMany(i => i.Interactions).HasForeignKey(i => i.EmpId);
            builder.Property(m => m.IntType).HasMaxLength(1);
            builder.Property(m => m.IntDate).HasDefaultValueSql("getdate()");
            builder.Property(m => m.Remarks).HasMaxLength(500);
        }
    }
}
