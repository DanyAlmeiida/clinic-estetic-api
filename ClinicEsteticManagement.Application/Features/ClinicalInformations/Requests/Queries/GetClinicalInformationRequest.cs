using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Queries
{
    public class GetClinicalInformationRequest : IRequest<ClinicalInformationDto>
    {
        public Guid Id { get; set; }
    }
}
