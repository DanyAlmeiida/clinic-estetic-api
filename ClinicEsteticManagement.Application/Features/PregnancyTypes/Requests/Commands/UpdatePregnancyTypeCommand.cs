using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands
{
    public class UpdatePregnancyTypeCommand : IRequest<PregnancyTypeDto>
    {
        public PregnancyTypeDto dto { get; set; }
    }
}
