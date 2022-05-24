using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Ports.Repositories.Base;
using Core.Identities;

namespace Application.Ports.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
    }
}
