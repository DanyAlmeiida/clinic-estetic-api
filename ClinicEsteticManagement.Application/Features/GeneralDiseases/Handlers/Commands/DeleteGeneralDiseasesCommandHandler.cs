using AutoMapper;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicEsteticManagement.Application.Features.GeneralDiseases.Handlers.Commands
{
    public class DeleteGeneralDiseasesCommandHandler : IRequestHandler<DeleteGeneralDiseasesCommand, Unit>
    {
        private readonly IGeneralDiseasesRepository repository;
        private readonly IMapper mapper;

        public DeleteGeneralDiseasesCommandHandler(IGeneralDiseasesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteGeneralDiseasesCommand request, CancellationToken cancellationToken)
        {
            var generalDisease = await repository.Get(request.Id);
            await repository.Delete(generalDisease);

            return Unit.Value;
        }
    }
}
