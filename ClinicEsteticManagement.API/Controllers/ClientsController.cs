using ClinicEsteticManagement.Application.DTOs.Client;
using ClinicEsteticManagement.Application.Features.Clients.Requests.Commands;
using ClinicEsteticManagement.Application.Features.Clients.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace ClinicEsteticManagement.API.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ClientsController> _logger;

        public ClientsController(ILogger<ClientsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        /// <summary>
        /// Creates a new client
        /// </summary>
        /// <param name="clientDto"></param>
        /// <returns>returns client-dto</returns>
        [HttpPost]
        public async Task<ActionResult<Guid>> Post([FromBody] CreateClientDto clientDto)
        {
            var command = new CreateClientCommand { Client = clientDto };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }
        /// <summary>
        /// returns all clients
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<ClientDto>>> GetAll()
        {
            var posts = await _mediator.Send(new GetClientsListRequest());
            return Ok(posts);
        }

        /// <summary>
        /// Gets client information based on id
        /// </summary>
        /// <param name="clientDto"></param>
        /// <returns>returns client-dto</returns>
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ClientDto>> Get([FromRoute] Guid id)
        {
            var client = await _mediator.Send(new GetClientDetailRequest() { Id = id });
            return Ok(client);
        }
        /// <summary>
        /// Update client information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="postDto"></param>
        /// <returns></returns>
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UpdateClientDto>> Put([FromRoute] Guid id, [FromBody] UpdateClientDto clientDto)
        {
            var command = new UpdateClientCommand() { Id = id, clientDto = clientDto};
            var post = await _mediator.Send(command);
            return Ok(post);
        }

    }
}