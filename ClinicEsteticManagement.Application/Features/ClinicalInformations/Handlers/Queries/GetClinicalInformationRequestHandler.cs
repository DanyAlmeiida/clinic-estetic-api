using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Queries;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Handlers.Queries
{
    public class GetClinicalInformationRequestHandler : IRequestHandler<GetClinicalInformationRequest, ClinicalInformationDto>
    {
        private readonly IClinicalInformationRepository repository;
        private readonly IMapper mapper;

        public GetClinicalInformationRequestHandler(IClinicalInformationRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<ClinicalInformationDto> Handle(GetClinicalInformationRequest request, CancellationToken cancellationToken)
        {
            var clinicalInformation = await repository.GetById(request.Id);
            if (clinicalInformation == null)
                throw new NotFoundException(nameof(clinicalInformation), request.Id);

            return mapper.Map<ClinicalInformationDto>(clinicalInformation);
        }
    }
}
