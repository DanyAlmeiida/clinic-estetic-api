using FluentValidation;

namespace ClinicEsteticManagement.Application.DTOs.Client.Validators
{
    public class CreateClientDtoValidator : AbstractValidator<CreateClientDto>
    {
        public CreateClientDtoValidator()
        {
            Include(new ClientDtoValidator());
        }
    }
}
