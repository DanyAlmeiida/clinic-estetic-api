using AutoMapper;
using ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ParamTables;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Handlers.Commands
{
    public class CreateWorkActivityTypeCommandHandler : IRequestHandler<CreateWorkActivityTypeCommand, Guid>
    {
        private readonly IWorkActivityTypeRepository repository;
        private readonly IMapper mapper;

        public CreateWorkActivityTypeCommandHandler(IWorkActivityTypeRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Guid> Handle(CreateWorkActivityTypeCommand request, CancellationToken cancellationToken)
        {
            WorkActivityType type = mapper.Map<WorkActivityType>(request.dto);

            type = await repository.Add(type);
            return type.Id;
        }
    }
}
