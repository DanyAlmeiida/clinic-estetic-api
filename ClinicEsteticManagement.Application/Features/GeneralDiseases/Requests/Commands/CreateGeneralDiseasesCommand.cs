﻿using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands
{
    public class CreateGeneralDiseasesCommand : IRequest<Guid>
    {
        public Guid ClientId { get; set; }
        public CreateGeneralDiseasesDto GeneralDiseasesDto { get; set; }
    }
}
