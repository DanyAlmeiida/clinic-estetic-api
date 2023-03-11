using ClinicEsteticManagement.Application.DTOs.Client;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.Clients.Requests.Queries
{
    public class GetClientsListRequest : IRequest<List<ClientDto>>
    {
    }
}
