using Application.Apps.Employees.Commands;
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
        [HttpPost]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeResponse>> GetEmployeeById([FromRoute] int id)
        {
            var request = new GetEmployeeByIdQuery() { EmployeeId = id };
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
