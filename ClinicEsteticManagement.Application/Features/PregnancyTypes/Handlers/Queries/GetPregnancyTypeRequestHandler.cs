using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using ClinicEsteticManagement.Application.Exceptions;
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
    public class GetPregnancyTypeRequestHandler : IRequestHandler<GetPregnancyTypeRequest, PregnancyTypeDto>
    {
        private readonly IPregnancyTypeRepository repository;
        private readonly IMapper mapper;

        public GetPregnancyTypeRequestHandler(IPregnancyTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<PregnancyTypeDto> Handle(GetPregnancyTypeRequest request, CancellationToken cancellationToken)
        {
            var type = await repository.Get(request.Id);
            if (type == null)
                throw new NotFoundException(nameof(type), request.Id);

            return mapper.Map<PregnancyTypeDto>(type);
        }
    }
}
