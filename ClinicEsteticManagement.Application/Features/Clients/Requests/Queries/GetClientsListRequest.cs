﻿using ClinicEsteticManagement.Application.DTOs.Client;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.Clients.Requests.Queries
{
    public class GetClientsListRequest : IRequest<List<ClientDto>>
    {
    }
}
