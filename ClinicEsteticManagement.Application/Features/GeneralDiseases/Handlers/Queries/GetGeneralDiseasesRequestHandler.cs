using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Queries;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Handlers.Queries
{
    public class GetGeneralDiseasesRequestHandler : IRequestHandler<GetGeneralDiseasesRequest, GeneralDiseasesDto>
    {
        private readonly IGeneralDiseasesRepository repository;
        private readonly IMapper mapper;

        public GetGeneralDiseasesRequestHandler(IGeneralDiseasesRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<GeneralDiseasesDto> Handle(GetGeneralDiseasesRequest request, CancellationToken cancellationToken)
        {
            var generalDisease = await repository.Get(request.Id);
            if (generalDisease == null)
                throw new NotFoundException(nameof(generalDisease), request.Id);

            return mapper.Map<GeneralDiseasesDto>(generalDisease);
        }
    }
}
