using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands
{
    public class DeletePregnancyTypeCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
