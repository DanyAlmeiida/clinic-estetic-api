using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Queries
{
    public class GetPregnancyTypeRequest : IRequest<PregnancyTypeDto>
    {
        public Guid Id { get; set; }
    }
}
