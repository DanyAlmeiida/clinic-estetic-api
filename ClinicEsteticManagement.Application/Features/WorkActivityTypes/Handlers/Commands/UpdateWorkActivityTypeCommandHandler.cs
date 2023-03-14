using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Handlers.Commands
{
    public class UpdateWorkActivityTypeCommandHandler : IRequestHandler<UpdateWorkActivityTypeCommand, WorkActivityTypeDto>
    {
        private readonly IWorkActivityTypeRepository repository;
        private readonly IMapper mapper;

        public UpdateWorkActivityTypeCommandHandler(IWorkActivityTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<WorkActivityTypeDto> Handle(UpdateWorkActivityTypeCommand request, CancellationToken cancellationToken)
        {
            var workActivityType = await repository.Get(request.dto.Id);
            if(workActivityType == null)
                throw new NotFoundException(nameof(workActivityType), request.dto.Id);

            workActivityType = mapper.Map(request.dto, workActivityType);

            await repository.Update(workActivityType);
            return mapper.Map<WorkActivityTypeDto>(workActivityType);
        }
    }
}
