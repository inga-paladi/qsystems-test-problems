using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Application.Common.Interfaces;
using EmployeeManagement.Infrastructure.Persistence;
using EmployeeManagement.Application.Employees.Commands.CreateEmployee;

namespace EmployeeManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmployeeDbContext>(options =>
                options.UseInMemoryDatabase("EmployeeDb"));

            services.AddScoped<IApplicationDbContext>(provider =>
                (IApplicationDbContext)provider.GetRequiredService<EmployeeDbContext>());

            // MediatR registration depends on your package version:

            // Option 1 (MediatR 12.x):
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(CreateEmployeeCommand).Assembly);
            });

            // Option 2 (older versions):
            // services.AddMediatR(typeof(CreateEmployeeCommand).Assembly);

            return services;
        }
    }
}
