using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Handlers.Commands
{
    public class CreatePregnancyTypeCommandHandler : IRequestHandler<CreatePregnancyTypeCommand, Guid>
    {
        private readonly IPregnancyTypeRepository repository;
        private readonly IMapper mapper;

        public CreatePregnancyTypeCommandHandler(IPregnancyTypeRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreatePregnancyTypeCommand request, CancellationToken cancellationToken)
        {
            PregnancyType type = mapper.Map<PregnancyType>(request.dto);

            type = await repository.Add(type);
            return type.Id;
        }
    }
}
