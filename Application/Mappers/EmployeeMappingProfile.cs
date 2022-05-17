using Application.Commands;
using Application.Responses;
using AutoMapper;
using Core.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee, EmployeeCommand>().ReverseMap();
        }
    }
}
