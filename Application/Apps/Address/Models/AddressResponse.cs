using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps.Address.Models
{
    public class AddressResponse
    {
        public string Name { get; set; }
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Core.Identities.Address, AddressResponse>().ReverseMap();
            }
        }
    }
}
