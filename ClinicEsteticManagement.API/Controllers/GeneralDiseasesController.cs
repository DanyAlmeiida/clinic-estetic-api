using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using ClinicEsteticManagement.Application.DTOs.Habits;
using ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Commands;
using ClinicEsteticManagement.Application.Features.EverydayHabits.Requests.Requests;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicEsteticManagement.API.Controllers
{
    [Route("api/everydayhabits")]
    [ApiController]
    public class EverydayHabitsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<EverydayHabitsController> _logger;

        public EverydayHabitsController(ILogger<EverydayHabitsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("{id:guid}")]
        public async Task<ActionResult<Guid>> Post([FromRoute] Guid id, [FromBody] CreateEverydayHabitDto dto)
        {
            var command = new CreateEverydayHabitCommand { ClientId = id, dto = dto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<EverydayHabitDto>> Get([FromRoute] Guid id)
        {
            var repsonse = await _mediator.Send(new GetEverydayHabitsRequest() { Id = id });
            return Ok(repsonse);
        }
        [HttpPut]
        public async Task<ActionResult<Guid>> Put([FromBody] EverydayHabitDto dto)
        {
            var command = new UpdateEverydayHabitCommand() { dto = dto };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Unit>> Delete([FromRoute] Guid id)
        {
            var command = new DeleteEverydayHabitCommand() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
