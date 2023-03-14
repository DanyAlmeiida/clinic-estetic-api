using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Queries;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Handlers.Queries
{
    public class GetListPregnancyTypeRequestHandler : IRequestHandler<GetListPregnancyTypeRequest, List<PregnancyTypeDto>>
    {
        private readonly IPregnancyTypeRepository repository;
        private readonly IMapper mapper;

        public GetListPregnancyTypeRequestHandler(IPregnancyTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<List<PregnancyTypeDto>> Handle(GetListPregnancyTypeRequest request, CancellationToken cancellationToken)
        {
            var lst = await repository.GetAll();
            return mapper.Map<List<PregnancyTypeDto>>(lst);
        }
    }
}
