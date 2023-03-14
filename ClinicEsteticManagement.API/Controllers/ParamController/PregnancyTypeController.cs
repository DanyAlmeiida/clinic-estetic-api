using ClinicEsteticManagement.Application.DTOs.PregnancyTypes;
using ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Features.PregnancyTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicEsteticManagement.API.Controllers.ParamController
{
    [Route("api/pregnancytypes")]
    [ApiController]

    public class PregnancyTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<PregnancyTypeController> _logger;

        public PregnancyTypeController(ILogger<PregnancyTypeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Post([FromBody] CreatePregnancyTypeDto dto)
        {
            var command = new CreatePregnancyTypeCommand { dto = dto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<PregnancyTypeDto>> Get([FromRoute] Guid id)
        {
            var repsonse = await _mediator.Send(new GetPregnancyTypeRequest() { Id = id });
            return Ok(repsonse);
        }
        [HttpGet]
        public async Task<ActionResult<List<PregnancyTypeDto>>> GetList([FromRoute] Guid id)
        {
            var repsonse = await _mediator.Send(new GetListPregnancyTypeRequest());
            return Ok(repsonse);
        }
        [HttpPut]
        public async Task<ActionResult<Guid>> Put([FromBody] PregnancyTypeDto dto)
        {
            var command = new UpdatePregnancyTypeCommand() { dto = dto };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Unit>> Delete([FromRoute] Guid id)
        {
            var command = new DeletePregnancyTypeCommand() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
