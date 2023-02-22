using ClinicEsteticManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Persistence.Contracts
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        public Task<Client> GetByClientId(Guid id);
    }
}
