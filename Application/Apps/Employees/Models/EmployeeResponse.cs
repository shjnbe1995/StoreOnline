using AutoMapper;
using Core.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public class EmployeeResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Employee, EmployeeResponse>().ReverseMap()
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src=>src.FirstName))
                    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            }
        }
    }
}
