using Application.Interfact;
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

namespace Application.Apps.Employees.Commands
{
    public class UpdateEmployeeCommand : IRequest<EmployeeResponse>
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }

        public class Handler : IRequestHandler<UpdateEmployeeCommand, EmployeeResponse>
        {
            private readonly IMapper _mapper;
            private readonly IEmployeeRepository _employeeRepo;
            private readonly IMailService _mailService;
            public Handler(IMapper mapper, IEmployeeRepository employeeRepo, IMailService mailService)
            {
                _employeeRepo = employeeRepo;
                _mapper = mapper;
                _mailService = mailService;
            }

            public async Task<EmployeeResponse> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
            {
                /*

                if (request == null)
                {
                    throw new ArgumentNullException("No data in request");
                }

                var empEntity = mapper.Map<UpdateEmployeeCommand, Employee>(request);

                var empDb = await _employeeRepo.GetByIdAsync(request.EmployeeId);
                if (empDb == null)
                {
                    throw new ArgumentException("Error to find employee in the database");
                }
                var empUpdateDb = mapper.Map<Employee, Employee>(empDb, empEntity);
                await _employeeRepo.UpdateAsync(empUpdateDb);

                var empDto = mapper.Map<Employee, EmployeeResponse>(empUpdateDb);
                return empDto;*/
                return new EmployeeResponse();
            }
        }
    }
}
