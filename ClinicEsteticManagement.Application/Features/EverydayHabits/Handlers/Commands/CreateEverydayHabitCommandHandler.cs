using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using ClinicEsteticManagement.Domain.ParamTables;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.EverydayHabits.Handlers.Commands
{
    public class CreateEverydayHabitCommandHandler : IRequestHandler<CreateEverydayHabitCommand, Guid>
    {
        private readonly IWorkActivityTypeRepository activityTypeRepository;
        private readonly IEverydayHabitRepository repository;
        private readonly IMapper mapper;

        public CreateEverydayHabitCommandHandler(IEverydayHabitRepository repository, IWorkActivityTypeRepository activityTypeRepository, IMapper mapper)
        {
            this.repository = repository;
            this.activityTypeRepository = activityTypeRepository;
            this.mapper = mapper;
        }


        public async Task<Guid> Handle(CreateEverydayHabitCommand request, CancellationToken cancellationToken)
        {
            var everydayHabit = mapper.Map<EverydayHabit>(request.dto);
            everydayHabit.ClientId = request.ClientId;

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

            var result = await repository.Add(everydayHabit);
            return result.Id;
        }
    }
}
