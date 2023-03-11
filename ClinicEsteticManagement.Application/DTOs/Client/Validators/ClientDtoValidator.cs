using FluentValidation;

namespace ClinicEsteticManagement.Application.DTOs.Client.Validators
{
    public class ClientDtoValidator : AbstractValidator<IClientDto>
    {
        public ClientDtoValidator()
        {
            RuleFor(client => client.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(client => client.BirthDate)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

        }
    }
}
