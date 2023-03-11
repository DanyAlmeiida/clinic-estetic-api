using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using ClinicEsteticManagement.Domain.ParamTables;
using Microsoft.EntityFrameworkCore;

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
            modelBuilder.Entity<Client>(x => { x.HasMany(s => s.ClinicalInformations); x.HasMany(s => s.GeneralDiseases); });

            modelBuilder.Entity<Client>().HasAlternateKey(c => c.ClientId);

            modelBuilder.Entity<GynecologicalConditions>()
                .HasOne(s => s.PregnancyType);

            modelBuilder.Entity<ClinicalInformation>()
                .HasOne(s => s.GynecologicalConditions);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var AddedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Added).ToList();
            AddedEntities.ForEach(E =>
            {
                var prop = E.Metadata.FindProperty("CreationDate");
                if (prop != null)
                {
                    E.Property("CreationDate").CurrentValue = DateTime.Now;
                }
            });

            var EditedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Modified).ToList();

            EditedEntities.ForEach(E =>
            {
                var prop = E.Metadata.FindProperty("ModifiedAt");
                if (prop != null)
                {
                    E.Property("ModifiedAt").CurrentValue = DateTime.Now;
                }
            });

            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<PregnancyType> PregnancyTypes { get; set; }
        public DbSet<GynecologicalConditions> GynecologicalConditions { get; set; }
        public DbSet<ClinicalInformation> ClinicalInformations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<GeneralDisease> GeneralDiseases { get; set; }
        public DbSet<WorkActivityType> WorkActivityTypes { get; set; }
    }
}
