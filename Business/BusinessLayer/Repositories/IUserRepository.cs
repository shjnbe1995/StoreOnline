using DomainCore.Entities;
using DomainCore.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore.Repositories
{
    public interface IUserRepository: IRepository<ApplicationUser>
    {
        //custom operations here
    }
}
