using DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IUser
    {
        Task<List<ApplicationUser>> GetAllUsers();
        Task<Guid> CreateUser(ApplicationUser user, string password);
        Task<ApplicationUser> UpdateUser(Guid id,string password, string newPassword, string email);
        Task<Boolean> DeleteUser(Guid id);
    }
}
