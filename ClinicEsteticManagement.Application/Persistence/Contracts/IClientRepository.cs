using ClinicEsteticManagement.Domain;

namespace ClinicEsteticManagement.Application.Persistence.Contracts
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        public Task<Client> GetByClientId(Guid id);
    }
}
