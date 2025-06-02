using EmployeeManagement.Application.Employees.Commands.CreateEmployee;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IMediator _mediator;

    public EmployeesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateEmployeeCommand command)
    {
        var employeeId = await _mediator.Send(command);
        return CreatedAtAction(nameof(Create), new { id = employeeId }, employeeId);
    }
}
