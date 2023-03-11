using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Queries
{
    public class GetGeneralDiseasesRequest : IRequest<GeneralDiseasesDto>
    {
        public Guid Id { get; set; }
    }
}
