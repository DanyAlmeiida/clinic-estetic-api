using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Queries;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.WorkActivityTypes.Handlers.Queries
{
    public class GetListWorkActivityTypeRequestHandler : IRequestHandler<GetListWorkActivityTypeRequest, List<WorkActivityTypeDto>>
    {
        private readonly IWorkActivityTypeRepository repository;
        private readonly IMapper mapper;

        public GetListWorkActivityTypeRequestHandler(IWorkActivityTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<List<WorkActivityTypeDto>> Handle(GetListWorkActivityTypeRequest request, CancellationToken cancellationToken)
        {
            var lst = await repository.GetAll();
            return mapper.Map<List<WorkActivityTypeDto>>(lst);
        }
    }
}
