using AutoMapper;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Handlers.Commands
{
    public class DeleteWorkActivityTypeCommandHandler : IRequestHandler<DeleteWorkActivityTypeCommand, Unit>
    {
        private readonly IWorkActivityTypeRepository repository;
        private readonly IMapper mapper;

        public DeleteWorkActivityTypeCommandHandler(IWorkActivityTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteWorkActivityTypeCommand request, CancellationToken cancellationToken)
        {
            var workActivityType = await repository.Get(request.Id);
            if (workActivityType == null)
                throw new NotFoundException(nameof(workActivityType), request.Id);

            await repository.Delete(workActivityType);

            return Unit.Value;
        }
    }
}
