using AutoMapper;
using ClinicEsteticManagement.Application.Features.Clients.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.Clients.Handlers.Commands
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Guid>
    {
        private readonly IClientRepository repository;
        private readonly IMapper mapper;

        public CreateClientCommandHandler(IClientRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = mapper.Map<Client>(request.Client);
            var result = await repository.Add(client);
            return result.Id;
        }
    }
}
