using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.Client;
using ClinicEsteticManagement.Application.Features.Clients.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.Clients.Handlers.Commands
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, UpdateClientDto>
    {
        private readonly IClientRepository repository;
        private readonly IMapper mapper;

        public UpdateClientCommandHandler(IClientRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<UpdateClientDto> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            Client client = await repository.GetByClientId(request.Id);

            mapper.Map(request.clientDto, client);
            if (request.clientDto.clinicalInformation != null && request.clientDto.clinicalInformation.GynecologicalConditions == null)
                client.ClinicalInformation.GynecologicalConditions = null;

            await repository.Update(client);

            client = await repository.GetByClientId(request.Id);
            return mapper.Map<UpdateClientDto>(client);
        }
    }
}
