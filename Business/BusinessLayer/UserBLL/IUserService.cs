using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainCore.ViewModels.UserViewModel;

namespace DomainCore.UserBLL
{
    public interface IUserService
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<Guid> CreateNewUser(UserVM user);
        Task UpdateUser(UserVM user);
        Task<Boolean> DeleteUser(Guid id);
    }

    // clean architecture - onion architecture
}
