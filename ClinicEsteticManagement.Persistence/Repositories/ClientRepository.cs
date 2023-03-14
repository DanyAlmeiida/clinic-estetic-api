using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClinicEsteticManagement.Persistence.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        private readonly DatabaseContext _dbContext;
        public ClientRepository(DatabaseContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<Client> GetByClientId(Guid id)
        {
            var clients = await _dbContext.Clients.
                Include(x => x.ClinicalInformations.OrderByDescending(x => x.CreationDate))
                .ThenInclude(x => x.GynecologicalConditions)
                .ThenInclude(x => x.PregnancyType)
                .Include(x => x.GeneralDiseases.OrderByDescending(x => x.CreationDate))
                .Include(x => x.EverydayHabits.OrderByDescending(x => x.CreationDate))
                .FirstAsync(x => x.Id == id);

            return clients;
        }
    }
}
