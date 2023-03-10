using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.Client;
using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Handlers.Commands
{
    public class UpdateClinicalInformationCommandHandler : IRequestHandler<UpdateClinicalInformationCommand, UpdateClinicalInformationDto>
    {
        private readonly IClinicalInformationRepository repository;
        private readonly IMapper mapper;

        public UpdateClinicalInformationCommandHandler(IClinicalInformationRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<UpdateClinicalInformationDto> Handle(UpdateClinicalInformationCommand request, CancellationToken cancellationToken)
        {
            ClinicalInformation clinicalInformation = await repository.GetById(request.UpdateClinicalInformationDto.Id);
            mapper.Map(request.UpdateClinicalInformationDto, clinicalInformation);

            if (request.UpdateClinicalInformationDto.GynecologicalConditions == null)
                clinicalInformation.GynecologicalConditions = null;


            await repository.Update(clinicalInformation);

            clinicalInformation = await repository.GetById(request.UpdateClinicalInformationDto.Id);
            return mapper.Map<UpdateClinicalInformationDto>(clinicalInformation);
        }
    }
}
