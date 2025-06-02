using EmployeeManagement.Application.Employees.Dtos;
using MediatR;

namespace EmployeeManagement.Application.Employees.Queries;

public class GetEmployeesQuery : IRequest<List<EmployeeDto>>
{
    public string? Search { get; set; }
    public string? SortBy { get; set; }
    public bool SortDesc { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
}
