using ClinicEsteticManagement.Application.DTOs.Client;
using ClinicEsteticManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.Clients.Requests.Commands
{
    public class CreateClientCommand : IRequest<Guid>
    {
        public CreateClientDto Client { get; set; }
    }
}
