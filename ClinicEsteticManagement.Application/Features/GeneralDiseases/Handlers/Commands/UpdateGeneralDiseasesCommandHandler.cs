using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain.ClinicalData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Handlers.Commands
{
    public class UpdateGeneralDiseasesCommandHandler : IRequestHandler<UpdateGeneralDiseasesCommand, UpdateGeneralDiseasesDto>
    {
        private readonly IGeneralDiseasesRepository repository;
        private readonly IMapper mapper;

        public UpdateGeneralDiseasesCommandHandler(IGeneralDiseasesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<UpdateGeneralDiseasesDto> Handle(UpdateGeneralDiseasesCommand request, CancellationToken cancellationToken)
        {
            var generalDiseases = await repository.Get(request.UpdateGeneralDiseasesDto.Id);
            mapper.Map(request.UpdateGeneralDiseasesDto, generalDiseases);

            await repository.Update(generalDiseases);

            generalDiseases = await repository.Get(request.UpdateGeneralDiseasesDto.Id);
            return mapper.Map<UpdateGeneralDiseasesDto>(generalDiseases);
        }
    }
}
