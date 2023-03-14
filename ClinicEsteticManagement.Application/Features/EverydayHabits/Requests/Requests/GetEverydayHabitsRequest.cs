using ClinicEsteticManagement.Application.DTOs.Habits;
using MediatR;

namespace ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Requests
{
    public class GetEverydayHabitsRequest : IRequest<EverydayHabitDto>
    {
        public Guid Id { get; set; }
    }
}
