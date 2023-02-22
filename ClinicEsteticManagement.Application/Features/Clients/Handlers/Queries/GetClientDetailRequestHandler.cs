using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.Client;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.Clients.Requests.Queries;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;
using System.Xml.Linq;

namespace ClinicEsteticManagement.Application.Features.Clients.Handlers.Queries
{
    public class GetClientDetailRequestHandler : IRequestHandler<GetClientDetailRequest, ClientDto>
    {
        private readonly IClientRepository repository;
        private readonly IMapper mapper;

        public GetClientDetailRequestHandler(IClientRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ClientDto> Handle(GetClientDetailRequest request, CancellationToken cancellationToken)
        {
            var client = await repository.GetByClientId(request.Id);
            if(client == null)
                throw new NotFoundException(nameof(client), request.Id);

            return mapper.Map<ClientDto>(client);
        }
    }
}
