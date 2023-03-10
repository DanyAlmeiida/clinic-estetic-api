using ClinicEsteticManagement.Domain.ClinicalData;

namespace ClinicEsteticManagement.Application.Persistence.Contracts
{
    public interface IClinicalInformationRepository : IGenericRepository<ClinicalInformation>
    {
        public Task<ClinicalInformation> GetById(Guid id);
    }
}
