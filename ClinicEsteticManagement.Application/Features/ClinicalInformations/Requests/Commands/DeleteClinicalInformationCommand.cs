using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands
{
    public class DeleteClinicalInformationCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
