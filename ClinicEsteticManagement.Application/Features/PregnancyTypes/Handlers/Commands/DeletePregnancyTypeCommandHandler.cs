using AutoMapper;
using ClinicEsteticManagement.Application.Exceptions;
using ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.PregnancyTypes.Handlers.Commands
{
    public class DeletePregnancyTypeCommandHandler : IRequestHandler<DeletePregnancyTypeCommand, Unit>
    {
        private readonly IPregnancyTypeRepository repository;
        private readonly IMapper mapper;

        public DeletePregnancyTypeCommandHandler(IPregnancyTypeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeletePregnancyTypeCommand request, CancellationToken cancellationToken)
        {
            var type = await repository.Get(request.Id);
            if (type == null)
                throw new NotFoundException(nameof(type), request.Id);

            await repository.Delete(type);

            return Unit.Value;
        }
    }
}
