using AutoMapper;
using ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Handlers.Commands
{
    public class CreateClinicalInformationCommandHandler : IRequestHandler<CreateClinicalInformationCommand, Guid>
    {
        private readonly IClinicalInformationRepository repository;
        private readonly IMapper mapper;

        public CreateClinicalInformationCommandHandler(IClinicalInformationRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreateClinicalInformationCommand request, CancellationToken cancellationToken)
        {
            var clinicalInformation = mapper.Map<ClinicalInformation>(request.ClinicalInformationDto);
            clinicalInformation.ClientId = request.Id;
            var result = await repository.Add(clinicalInformation);
            return result.Id;
        }
    }
}
