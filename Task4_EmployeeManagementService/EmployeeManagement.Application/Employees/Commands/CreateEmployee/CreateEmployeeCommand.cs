using MediatR;

namespace EmployeeManagement.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommand: IRequest<Guid>
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}
