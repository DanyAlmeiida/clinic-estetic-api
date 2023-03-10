using ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands;
using ClinicEsteticManagement.Application.Persistence.Contracts;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.ClinicalInformations.Handlers.Commands
{
    public class DeleteClinicalInformationCommandHandler : IRequestHandler<DeleteClinicalInformationCommand, Unit>
    {
        private readonly IClinicalInformationRepository repository;

        public DeleteClinicalInformationCommandHandler(IClinicalInformationRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Unit> Handle(DeleteClinicalInformationCommand request, CancellationToken cancellationToken)
        {
            var clinicalInformation = await repository.Get(request.Id);

            await repository.Delete(clinicalInformation);

            return Unit.Value;
        }
    }
}
