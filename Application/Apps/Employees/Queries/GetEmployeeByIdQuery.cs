using Application.Responses;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeResponse>
    {
        //cqrs????
        public int EmployeeId { get; set; }

        public class Handler : IRequestHandler<GetEmployeeByIdQuery, EmployeeResponse>
        {
            private readonly IEmployeeRepository _employeeRepo;
            public Handler(IEmployeeRepository employeeRepository)
            {
                _employeeRepo = employeeRepository;
            }
            public async Task<EmployeeResponse> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
            {
                if(request == null)
                {
                    throw new ArgumentNullException("Reqest error");
                }

                //return employeeResponse;
            }
        }
    }
}
