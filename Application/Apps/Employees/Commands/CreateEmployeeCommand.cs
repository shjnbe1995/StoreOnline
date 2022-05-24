
using Application.Ports.Repositories;
using Application.Ports.Repositories.Base;
using Application.Responses;
using AutoMapper;
using Core.Identities;
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
            private readonly IEmployeeRepository _employeeRepo;
            private readonly IAddressRepository _addressRepo;
            public Handler(IEmployeeRepository employeeRepo, IMapper mapper, IAddressRepository addressRepo)
            {
                _employeeRepo = employeeRepo;
                _mapper = mapper;
                _addressRepo = addressRepo;
            }
            public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException("No data in request");
                }
                var employeeEntity = _mapper.Map<Employee>(request);

                var newEmployee = await _employeeRepo.AddAsync(employeeEntity);

                if (newEmployee == null)
                {
                    throw new ArgumentException("Error to add new employee");
                }
                var employeeDto = _mapper.Map<EmployeeResponse>(employeeEntity);
                return employeeDto;
            }

        }
    }
}
