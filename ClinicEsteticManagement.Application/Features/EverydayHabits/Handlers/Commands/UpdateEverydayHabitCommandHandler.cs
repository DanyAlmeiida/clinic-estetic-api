using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Application.DTOs.Habits;
using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using ClinicEsteticManagement.Domain.ParamTables;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.EverydayHabits.Handlers.Commands
{
    public class UpdateEverydayHabitCommandHandler : IRequestHandler<UpdateEverydayHabitCommand, EverydayHabitDto>
    {
        private readonly IEverydayHabitRepository repository;
        private readonly IWorkActivityTypeRepository activityTypeRepository;
        private readonly IMapper mapper;

        public UpdateEverydayHabitCommandHandler(IEverydayHabitRepository repository, IWorkActivityTypeRepository activityTypeRepository, IMapper mapper)
        {
            this.repository = repository;
            this.activityTypeRepository = activityTypeRepository;
            this.mapper = mapper;
        }
        public async Task<EverydayHabitDto> Handle(UpdateEverydayHabitCommand request, CancellationToken cancellationToken)
        {
            EverydayHabit everydayHabit = await repository.GetById(request.dto.Id);
            mapper.Map(request.dto, everydayHabit);


            if (request.dto.WorkActivitys != null && request.dto.WorkActivitys.Count > 0)
            {
                List<WorkActivityType> lstWorkActivityTypes = new List<WorkActivityType>();
                foreach (WorkActivityTypeDto item in request.dto.WorkActivitys)
                {
                    var activityType = await activityTypeRepository.Get(item.Id);
                    lstWorkActivityTypes.Add(activityType);
                }
                everydayHabit.WorkActivitys = lstWorkActivityTypes;
            }

            await repository.Update(everydayHabit);

            everydayHabit = await repository.GetById(request.dto.Id);
            return mapper.Map<EverydayHabitDto>(everydayHabit);
        }
    }
}
