using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Queries
{
    public class GetGeneralDiseasesRequest : IRequest<GeneralDiseasesDto>
    {
        public Guid Id { get; set; }
    }
}
