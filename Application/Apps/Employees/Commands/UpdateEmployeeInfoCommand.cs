using Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps.Employees.Commands
{
    public class UpdateEmployeeInfoCommand : IRequest<EmployeeResponse>
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string address { get; set; }

        public class Handler : IRequestHandler<UpdateEmployeeInfoCommand, EmployeeResponse>
        {
            public Handler(dbcontext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                _mapper = mapper;
            }

            public async Task<EmployeeResponse> Handle(UpdateEmployeeInfoCommand request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException("");
                }

                // dbcontext -> employee (entity)
                // include? to reference
                // employee.ChangeAddress(newAddress) -> change -> save

                // database schema? class? shoponline?


                var newEmployee = await _employeeRepo.AddAsync(employeeEntitiy);
                var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);
                return employeeResponse;
            }
        }
    }
}
