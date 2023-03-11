using ClinicEsteticManagement.Application.DTOs.ClinicalData;
using ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Commands;
using ClinicEsteticManagement.Application.Features.ClinicalInformations.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicEsteticManagement.API.Controllers
{
    [Route("api/clinical")]
    [ApiController]
    public class ClinicalInformationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ClientsController> _logger;

        public ClinicalInformationController(ILogger<ClientsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
        /// <summary>
        /// Creates a new clinical information record
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clinicalInformationDto"></param>
        /// <returns>returns Guid</returns>
        [HttpPost("{id:guid}")]
        public async Task<ActionResult<Guid>> Post([FromRoute] Guid id, [FromBody] CreateClinicalInformationDto clinicalInformationDto)
        {
            var command = new CreateClinicalInformationCommand { Id = id, ClinicalInformationDto = clinicalInformationDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        /// <summary>
        ///  Gets clinical information based on id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ClinicalInformationDto>> Get([FromRoute] Guid id)
        {
            var clinicalInfo = await _mediator.Send(new GetClinicalInformationRequest() { Id = id });
            return Ok(clinicalInfo);
        }
        /// <summary>
        /// Update clinical information
        /// </summary>
        /// <param name="UpdateClinicalInformationDto"></param>
        /// <returns></returns>
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> Put([FromRoute] Guid id, [FromBody] UpdateClinicalInformationDto UpdateClinicalInformationDto)
        {
            var command = new UpdateClinicalInformationCommand() { ClientId = id, UpdateClinicalInformationDto = UpdateClinicalInformationDto };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        /// <summary>
        /// Deletes clinicalInformation
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Unit>> Delete([FromRoute] Guid id)
        {
            var command = new DeleteClinicalInformationCommand() { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }


    }
}
