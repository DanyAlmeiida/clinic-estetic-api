using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands
{
    public class UpdateGeneralDiseasesCommand : IRequest<UpdateGeneralDiseasesDto>
    {
        public UpdateGeneralDiseasesDto UpdateGeneralDiseasesDto { get; set; }
    }
}
