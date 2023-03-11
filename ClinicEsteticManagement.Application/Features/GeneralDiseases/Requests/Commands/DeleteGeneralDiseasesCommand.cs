using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands
{
    public class DeleteGeneralDiseasesCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
