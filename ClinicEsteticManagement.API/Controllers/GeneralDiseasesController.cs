using ClinicEsteticManagement.Application.DTOs.GeneralDiseases;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Commands;
using ClinicEsteticManagement.Application.Features.GeneralDiseases.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicEsteticManagement.API.Controllers
{
    [Route("api/diseases")]
    [ApiController]
    public class GeneralDiseasesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ClientsController> _logger;

        public GeneralDiseasesController(ILogger<ClientsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("{id:guid}")]
        public async Task<ActionResult<Guid>> Post([FromRoute] Guid id, [FromBody] CreateGeneralDiseasesDto createGeneralDiseasesDto)
        {
            var command = new CreateGeneralDiseasesCommand { ClientId = id, GeneralDiseasesDto = createGeneralDiseasesDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<GeneralDiseasesDto>> Get([FromRoute] Guid id)
        {
            var repsonse = await _mediator.Send(new GetGeneralDiseasesRequest() { Id = id });
            return Ok(repsonse);
        }
        [HttpPut]
        public async Task<ActionResult<Guid>> Put([FromBody] UpdateGeneralDiseasesDto updateGeneralDiseasesDto)
        {
            var command = new UpdateGeneralDiseasesCommand() {  UpdateGeneralDiseasesDto = updateGeneralDiseasesDto };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Unit>> Delete([FromRoute] Guid id)
        {
            var command = new DeleteGeneralDiseasesCommand() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
