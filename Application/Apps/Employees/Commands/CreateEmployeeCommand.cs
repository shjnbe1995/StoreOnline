using Application.Commands;
using Application.Responses;
using AutoMapper;
using Core.Identities;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Responses.EmployeeResponse;

namespace Application.Apps.Employees.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public class Handler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
        {
            private readonly IMapper _mapper;
            private readonly EmployeeRepository _employeeRepo;
            public Handler(EmployeeRepository employeeRepo, IMapper mapper)
            {
                _employeeRepo = employeeRepo;
                _mapper = mapper;
            }
            public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException("No data in request");
                }

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new MappingProfile());
                });
                var mapper = config.CreateMapper();
                var employeeEntity = mapper.Map<CreateEmployeeCommand, Employee>(request);

                var newEmployee = await _employeeRepo.AddAsync(employeeEntity);

                if (newEmployee == null)
                {
                    throw new ArgumentException("Error to add new employee");
                }
                var employeeDto = mapper.Map<Employee, EmployeeResponse>(employeeEntity);
                return employeeDto;
            }
        }
    }
}
