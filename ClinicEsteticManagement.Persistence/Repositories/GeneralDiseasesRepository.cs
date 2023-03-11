using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using Microsoft.EntityFrameworkCore;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class GeneralDiseasesRepository : GenericRepository<GeneralDisease>, IGeneralDiseasesRepository
    {
        private readonly DatabaseContext _dbContext;
        public GeneralDiseasesRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<ClinicalInformation> GetById(Guid id)
        {
            var clinicalInformation = await _dbContext.ClinicalInformations
                .Include(x => x.GynecologicalConditions)
                .ThenInclude(x => x.PregnancyType)
                .FirstAsync(x => x.Id == id);

            return clinicalInformation;
        }
    }
}
