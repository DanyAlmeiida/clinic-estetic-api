using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.Client;
using ClinicEsteticManagement.Application.Features.Clients.Requests.Queries;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.Clients.Handlers.Queries
{
    public class GetClientsListRequestHandler : IRequestHandler<GetClientsListRequest, List<ClientDto>>
    {
        private readonly IClientRepository repository;
        private readonly IMapper mapper;

        public GetClientsListRequestHandler(IClientRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<ClientDto>> Handle(GetClientsListRequest request, CancellationToken cancellationToken)
        {
            var clientsList = await repository.GetAll();

            return mapper.Map<List<ClientDto>>(clientsList);
        }
    }
}
