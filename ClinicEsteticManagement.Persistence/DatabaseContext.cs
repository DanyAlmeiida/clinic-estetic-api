using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using ClinicEsteticManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        //when db is being generate
        //set rules
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
               .HasOne(s => s.ClinicalInformation);

            modelBuilder.Entity<Client>().HasAlternateKey(c => c.ClientId);

            modelBuilder.Entity<GynecologicalConditions>()
                .HasOne(s => s.PregnancyType);

            modelBuilder.Entity<ClinicalInformation>()
                .HasOne(s => s.GynecologicalConditions);

           

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreationDate = DateTime.Now;
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Entity.ModifiedAt = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<PregnancyType> PregnancyTypes { get; set; }
        public DbSet<GynecologicalConditions> GynecologicalConditions { get; set; }
        public DbSet<ClinicalInformation> ClinicalInformations { get; set; }
        public DbSet<Client> Clients { get; set; }
        
    }
}
