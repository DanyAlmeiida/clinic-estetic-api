using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Include(x => x.ClinicalInformation)
                .ThenInclude(x => x.GynecologicalConditions)
                .ThenInclude( x => x.PregnancyType)
                .FirstAsync(x => x.Id == id);

            return clients;
        }
    }
}
