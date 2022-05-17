using Application.Commands;
using Application.Mappers;
using Application.Responses;
using Core.Identities;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class EmployeeHandler : IRequestHandler<EmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepo;
        public EmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }
        public async Task<EmployeeResponse> Handle(EmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntitiy = EmployeeMapper.Mapper.Map<Employee>(request);
            if (employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _employeeRepo.AddAsync(employeeEntitiy);
            var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);
            return employeeResponse;
        }
    }
}
