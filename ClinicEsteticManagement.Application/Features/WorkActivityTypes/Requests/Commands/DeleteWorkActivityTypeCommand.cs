using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Commands
{
    public class DeleteWorkActivityTypeCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
