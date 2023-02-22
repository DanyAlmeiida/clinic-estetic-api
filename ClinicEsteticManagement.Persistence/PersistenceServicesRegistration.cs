using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicEsteticManagement.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(
                configuration.GetConnectionString("BlogContextConnectionString"),
                b => b.MigrationsAssembly("ClinicEsteticManagement.Persistence")));

            services.AddScoped(typeof(Repositories.IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClinicalInformationRepository, ClinicalInformationRepository>();
            services.AddScoped<IGynecologicalConditionRepository, GynecologicalConditionRepository>();
            return services;
        }
    }
}