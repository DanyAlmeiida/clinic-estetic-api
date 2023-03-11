using ClinicEsteticManagement.Application.DTOs.Client;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.Clients.Requests.Commands
{
    public class CreateClientCommand : IRequest<Guid>
    {
        public CreateClientDto Client { get; set; }
    }
}
