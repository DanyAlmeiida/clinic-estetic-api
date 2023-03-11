using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class GynecologicalConditionRepository : GenericRepository<GynecologicalConditions>, IGynecologicalConditionRepository
    {
        private readonly DatabaseContext _dbContext;
        public GynecologicalConditionRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
