using Application.Responses;
using AutoMapper;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Application.Apps.Address.Models.AddressResponse;

namespace Application.Apps.Employees.Commands
{
    public class DeleteEmployeeCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public class Handler : IRequestHandler<DeleteEmployeeCommand, bool>
        {
            private readonly IMapper _mapper;
            private readonly EmployeeRepository _employeeRepo;
            public Handler(IMapper mapper, EmployeeRepository employeeRepo)
            {
                _employeeRepo = employeeRepo;
                _mapper = mapper;
            }

            public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException("No data in request");
                }
                var empDb = await _employeeRepo.GetByIdAsync(request.Id);
                if (empDb == null)
                {
                    throw new ArgumentNullException("Cannot find employee in database");
                }
                return _employeeRepo.DeleteAsync(empDb).IsCompletedSuccessfully ? true: false;

            }
        }
    }
}
