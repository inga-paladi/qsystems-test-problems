using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Domain.Entities;
using System.Collections.Generic;

namespace EmployeeManagement.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Employee> Employees { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
