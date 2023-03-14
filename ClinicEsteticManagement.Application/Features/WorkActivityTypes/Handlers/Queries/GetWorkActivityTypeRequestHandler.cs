using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Queries;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Handlers.Queries
{
    public class GetWorkActivityTypeRequestHandler : IRequestHandler<GetWorkActivityTypeRequest, WorkActivityTypeDto>
    {
        private readonly IWorkActivityTypeRepository repository;
        private readonly IMapper mapper;

        public GetWorkActivityTypeRequestHandler(IWorkActivityTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<WorkActivityTypeDto> Handle(GetWorkActivityTypeRequest request, CancellationToken cancellationToken)
        {
            var type = await repository.Get(request.Id);
            if (type == null)
                throw new NotFoundException(nameof(type), request.Id);

            return mapper.Map<WorkActivityTypeDto>(type);
        }
    }
}
