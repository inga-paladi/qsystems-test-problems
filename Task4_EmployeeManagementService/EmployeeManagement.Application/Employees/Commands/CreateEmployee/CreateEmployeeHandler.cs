using MediatR;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Application.Common.Interfaces;
using EmployeeManagement.Application.Common.Helpers;
using EmployeeManagement.Application.Employees.Commands.CreateEmployee;

namespace EmployeeManagement.Application.Employees.Commands;

public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Guid>
{
    private readonly IApplicationDbContext _context;

    public CreateEmployeeCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var employee = new Employee
        {
            Id = Guid.NewGuid(),
            FullName = request.FullName,
            Position = request.Position,
            Department = request.Department,
            DateOfBirth = request.DateOfBirth,
            HireDate = request.HireDate,
            Salary = SalaryCalculator.Calculate(request.Position)
        };

        _context.Employees.Add(employee);
        await _context.SaveChangesAsync(cancellationToken);

        return employee.Id;
    }
}
