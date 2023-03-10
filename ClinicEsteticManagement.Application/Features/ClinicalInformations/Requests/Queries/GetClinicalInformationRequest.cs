using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Queries
{
    public class GetClinicalInformationRequest : IRequest<ClinicalInformationDto>
    {
        public Guid Id { get; set; }
    }
}
