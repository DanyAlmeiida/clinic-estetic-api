using AutoMapper;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Handlers.Commands
{
    public class CreateGeneralDiseasesCommandHandler : IRequestHandler<CreateGeneralDiseasesCommand, Guid>
    {
        private readonly IGeneralDiseasesRepository repository;
        private readonly IMapper mapper;

        public CreateGeneralDiseasesCommandHandler(IGeneralDiseasesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreateGeneralDiseasesCommand request, CancellationToken cancellationToken)
        {
            var generalDiseases = mapper.Map<GeneralDisease>(request.GeneralDiseasesDto);
            generalDiseases.ClientId = request.ClientId;
            var result = await repository.Add(generalDiseases);
            return result.Id;
        }
    }
}
