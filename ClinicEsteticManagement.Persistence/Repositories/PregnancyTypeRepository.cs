using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class PregnancyTypeRepository : GenericRepository<PregnancyType>, IPregnancyTypeRepository
    {
        private readonly DatabaseContext dbContext;

        public PregnancyTypeRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
