using DataLayer.DataContext;
using DataLayer.Entities;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DomainCore.ViewModels.UserViewModel;

namespace DomainCore.UserBLL
{
    // service lifecycle
    public class UserService : IUserService
    {
        // dung nhièu nơi trong 1 request lifetime -> scoped
        public readonly IDatabaseContext _context;
        public readonly IUser _user;
        public UserService(IDatabaseContext context, IUser user)
        {
            _context = context;
            _user = user;
        }
        public Task<List<ApplicationUser>> GetAllUsers()
        {
            return _user.GetAllUsers();
        }
        public async Task<Guid> CreateNewUser(UserVM userVM)
        {
            var user = new ApplicationUser()
            {
                UserName = userVM.Username,
                Email = userVM.Email,
                Id = Guid.NewGuid(),
            };

            return await _user.CreateUser(user, userVM.Password);
        }

        public async Task<Boolean> DeleteUser(Guid id)
        {
            return await _user.DeleteUser(id); 
        }
                
        public async Task UpdateUser(UserVM user)
        {
            if(user == null)
            {
                throw new NotImplementedException("User is not null");
            }
            if(user.NewPassword != user.ConfirmedNewPassword)
            {
                throw new NotImplementedException("Password and confirmed password do not match");
            }
            if (!user.Email.EndsWith("@gmail.com")){
                throw new NotImplementedException("Email does not match");
            }
            await _user.UpdateUser(user.Id,user.Password, user.NewPassword, user.Email);
        }
    }
}
