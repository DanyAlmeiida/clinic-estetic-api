using ClinicEsteticManagement.Application.DTOs.WorkActivityTypes;
using ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Commands;
using ClinicEsteticManagement.Application.Features.WorkActivityTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicEsteticManagement.API.Controllers.ParamController
{
    [Route("api/workingactivitytypes")]
    [ApiController]

    public class WorkingActivityTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WorkingActivityTypeController> _logger;

        public WorkingActivityTypeController(ILogger<WorkingActivityTypeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Post([FromBody] CreateWorkActivityTypeDto dto)
        {
            var command = new CreateWorkActivityTypeCommand { dto = dto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<WorkActivityTypeDto>> Get([FromRoute] Guid id)
        {
            var repsonse = await _mediator.Send(new GetWorkActivityTypeRequest() { Id = id });
            return Ok(repsonse);
        }
        [HttpGet]
        public async Task<ActionResult<List<WorkActivityTypeDto>>> GetList([FromRoute] Guid id)
        {
            var repsonse = await _mediator.Send(new GetListWorkActivityTypeRequest());
            return Ok(repsonse);
        }
        [HttpPut]
        public async Task<ActionResult<Guid>> Put([FromBody] WorkActivityTypeDto dto)
        {
            var command = new UpdateWorkActivityTypeCommand() { dto = dto };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Unit>> Delete([FromRoute] Guid id)
        {
            var command = new DeleteWorkActivityTypeCommand() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
