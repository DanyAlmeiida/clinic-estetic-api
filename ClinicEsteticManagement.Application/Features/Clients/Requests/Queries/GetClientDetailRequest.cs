using ClinicEsteticManagement.Application.DTOs.Client;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.Clients.Requests.Queries
{
    public class GetClientDetailRequest : IRequest<ClientDto>
    {
        public Guid Id { get; set; }
    }
}
