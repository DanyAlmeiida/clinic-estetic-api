using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Application.DTOs.Habits;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Requests;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.EverydayHabits.Handlers.Requests
{
    public class GetEverydayHabitRequestHandler : IRequestHandler<GetEverydayHabitsRequest, EverydayHabitDto>
    {
        private readonly IEverydayHabitRepository repository;
        private readonly IMapper mapper;

        public GetEverydayHabitRequestHandler(IEverydayHabitRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<EverydayHabitDto> Handle(GetEverydayHabitsRequest request, CancellationToken cancellationToken)
        {
            var everydayHabitDto = await repository.GetById(request.Id);
            if (everydayHabitDto == null)
                throw new NotFoundException(nameof(everydayHabitDto), request.Id);

            return mapper.Map<EverydayHabitDto>(everydayHabitDto);
        }
    }
}
