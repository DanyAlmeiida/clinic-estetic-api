using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Commands
{
    public class DeleteEverydayHabitCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
