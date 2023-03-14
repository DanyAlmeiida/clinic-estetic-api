using AutoMapper;
using ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands;
using ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.EverydayHabits.Handlers.Commands
{
    public class DeleteEverydayHabitCommandHandler : IRequestHandler<DeleteEverydayHabitCommand, Unit>
    {
        private readonly IEverydayHabitRepository repository;
        private readonly IMapper mapper;

        public DeleteEverydayHabitCommandHandler(IEverydayHabitRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteEverydayHabitCommand request, CancellationToken cancellationToken)
        {
            var everydayHabit = await repository.Get(request.Id);

            await repository.Delete(everydayHabit);

            return Unit.Value;
        }
    }
}
