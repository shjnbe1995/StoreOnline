using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class EmployeeCommand : IRequest<EmployeeResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public async Task<EmployeeResponse> Handle(EmployeeCommand request, CancellationToken cancellationToken)
        {
            // type a
            // type b

            //return type b
            // retrieve from database is type a

            // b.name = a.name
            // call automapper to map
            // map from a to b? => create mapping profile

            //Todo: refactor to Imapper aka inject mapper -> required to DI
            //var employeeEntitiy = EmployeeMapper.Mapper.Map<Employee>(request);
            //if (employeeEntitiy is null)
            //{
            //    throw new ApplicationException("Issue with mapper");
            //}

            if (request == null)
            {
                throw new ArgumentNullException("");
            }

            // map tay
            ///var employeeEntitiy = EmployeeMapper.Mapper.Map<Employee>(request);

            if (employeeEntitiy is null)
            {
                throw new ArgumentNullException("Issue with mapper");
            }

            var employee = new employee(name, age)

            var newEmployee = await _employeeRepo.AddAsync(employee);
            var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);

            return employeeResponse;
        }
    }
}
