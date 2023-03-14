using AutoMapper;
using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using ClinicEsteticManagement.Domain;
using ClinicEsteticManagement.Domain.ClinicalData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Handlers.Commands
{
    public class UpdatePregnancyTypeCommandHandler : IRequestHandler<UpdatePregnancyTypeCommand, PregnancyTypeDto>
    {
        private readonly IPregnancyTypeRepository repository;
        private readonly IMapper mapper;

        public UpdatePregnancyTypeCommandHandler(IPregnancyTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<PregnancyTypeDto> Handle(UpdatePregnancyTypeCommand request, CancellationToken cancellationToken)
        {
            var pregnancyType = await repository.Get(request.dto.Id);
            if(pregnancyType == null)
                throw new NotFoundException(nameof(pregnancyType), request.dto.Id);

            pregnancyType = mapper.Map(request.dto, pregnancyType);

            await repository.Update(pregnancyType);
            return mapper.Map<PregnancyTypeDto>(pregnancyType);
        }
    }
}
