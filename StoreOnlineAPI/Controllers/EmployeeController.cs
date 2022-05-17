using Application.Commands;
using Application.Queries;
using Application.Responses;
using Core.Identities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace StoreOnlineAPI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Employee>> Get()
        {
            return await _mediator.Send(new GetAllEmployeeQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] EmployeeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
